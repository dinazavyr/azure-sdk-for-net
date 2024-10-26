﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Azure.Provisioning.Generator.Model;

public class SimpleModel(Specification spec, Type armType, string name, string? ns = default, string? description = default)
    : TypeModel(spec, armType, name, ns, description)
{
    public override string ToString() => $"<Model {Namespace}.{Name}>";

    public override void Generate()
    {
        ContextualException.WithContext(
            $"Generating simple model {Namespace}.{Name}",
            () =>
            {
                IndentWriter writer = new();
                writer.WriteLine("// Copyright (c) Microsoft Corporation. All rights reserved.");
                writer.WriteLine("// Licensed under the MIT License.");
                writer.WriteLine();
                writer.WriteLine("// <auto-generated/>");
                writer.WriteLine();

                var fence = new IndentWriter.Fenceposter();
                HashSet<string> namespaces = CollectNamespaces();
                if (FromExpression) { namespaces.Add("Azure.Provisioning.Expressions"); }
                if (FromExpression) { namespaces.Add("System.ComponentModel"); }
                foreach (string ns in namespaces.Order())
                {
                    if (fence.RequiresSeparator) { /* Don't write anything here */ }
                    writer.WriteLine($"using {ns};");
                }
                if (fence.RequiresSeparator) { writer.WriteLine(); }

                writer.WriteLine($"namespace {Namespace};");
                writer.WriteLine();
                writer.WriteLine($"/// <summary>");
                writer.WriteWrapped(Description ?? (Name + "."));
                writer.WriteLine($"/// </summary>");
                writer.WriteLine($"public partial class {Name} : {(BaseType is not null ? BaseType.Name : "ProvisionableConstruct")}");
                using (writer.Scope("{", "}"))
                {
                    fence = new IndentWriter.Fenceposter();

                    // Write the properties
                    foreach (Property property in Properties)
                    {
                        if (fence.RequiresSeparator) { writer.WriteLine(); }

                        if (!property.HideAccessors)
                        {
                            writer.WriteLine($"/// <summary>");
                            string orSets = property.IsReadOnly ? "" : " or sets";
                            writer.WriteWrapped(property.Description ?? $"Gets{orSets} the {property.Name}.");
                            writer.WriteLine($"/// </summary>");
                            writer.Write($"public {property.BicepTypeReference} {property.Name} ");
                            writer.Write($"{{ get => {property.FieldName}; ");
                            if (!property.IsReadOnly) { writer.Write($"set => {property.FieldName}.Assign(value); "); }
                            writer.WriteLine("}");
                        }
                        writer.WriteLine($"private readonly {property.BicepTypeReference} {property.FieldName};");
                    }

                    // Write the default value partial methods
                    foreach (Property property in Properties.Where(p => p.GenerateDefaultValue))
                    {
                        if (fence.RequiresSeparator) { writer.WriteLine(); }

                        writer.WriteLine($"/// <summary>");
                        writer.WriteWrapped($"Get the default value for the {property.Name} property.");
                        writer.WriteLine($"/// </summary>");
                        writer.WriteLine($"private partial {property.BicepTypeReference} Get{property.Name}DefaultValue();");
                    }
                    
                    // Write the .ctor
                    if (fence.RequiresSeparator) { writer.WriteLine(); }
                    writer.WriteLine($"/// <summary>");
                    writer.WriteWrapped($"Creates a new {Name}.");
                    writer.WriteLine($"/// </summary>");
                    writer.Write($"public {Name}()");
                    if (BaseType is not null)
                    {
                        writer.Write(" : base()");
                    }
                    writer.WriteLine();
                    using (writer.Scope("{", "}"))
                    {
                        if (DiscriminatorName is not null)
                        {
                            writer.WriteLine($"BicepValue<string>.DefineProperty(this, \"{DiscriminatorName}\", [\"{DiscriminatorName}\"], defaultValue: \"{DiscriminatorValue}\");");
                        }
                        foreach (Property property in Properties)
                        {
                            writer.Write($"{property.FieldName} = {property.BicepTypeReference}");
                            writer.Write($".DefineProperty(this, \"{property.Name}\", ");
                            writer.Write($"[{string.Join(", ", (property.Path ?? [property.Name]).Select(s => $"\"{s}\""))}]");
                            if (property.IsRequired) { writer.Write($", isRequired: true"); }
                            if (property.IsReadOnly) { writer.Write($", isOutput: true"); }
                            if (property.IsSecure) { writer.Write($", isSecure: true"); }
                            if (property.GenerateDefaultValue) { writer.Write($", defaultValue: Get{property.Name}DefaultValue()"); }
                            if (property.Format is not null) { writer.Write($", format: \"{property.Format}\""); }
                            writer.WriteLine($");");
                        }
                    }

                    // Add the FromExpression method
                    if (FromExpression)
                    {
                        if (fence.RequiresSeparator) { writer.WriteLine(); }

                        writer.WriteLine($"/// <summary>");
                        writer.WriteWrapped($"Creates a new {Name} resource from a Bicep expression that evaluates to a {Name}.");
                        writer.WriteLine($"/// </summary>");
                        writer.WriteLine($"/// <param name=\"expression\">");
                        writer.WriteWrapped($"A Bicep expression that evaluates to a {Name} resource.");
                        writer.WriteLine($"/// </param>");
                        writer.WriteLine($"/// <returns>A {Name} resource.</returns>");
                        writer.WriteLine($"[EditorBrowsable(EditorBrowsableState.Never)]");
                        writer.WriteLine($"public static {Name} FromExpression(BicepExpression expression)");
                        using (writer.Scope("{", "}"))
                        {
                            writer.WriteLine($"{Name} resource = new();");
                            writer.WriteLine($"resource.OverrideWithExpression(expression);");
                            writer.WriteLine($"return resource;");
                        }
                    }
                }

                // Write out the model
                Spec!.SaveFile(Path.Combine("Models", $"{Name}.cs"), writer.ToString());
            });
    }
}
