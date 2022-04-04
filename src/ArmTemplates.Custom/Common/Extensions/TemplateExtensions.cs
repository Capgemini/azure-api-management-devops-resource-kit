// --------------------------------------------------------------------------
//  <copyright file="TemplateExtensions.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Common.Extensions
{
    public static class TemplateExtensions
    {
        public static List<Template> AddOrMergeRange(this List<Template> templates, List<Template> sourceTemplates)
        {
            if (templates.Count == 0)
            {
                templates.AddRange(sourceTemplates);
            }
            else
            {
                for (int i = 0; i < templates.Count; i++)
                {
                    Template template = templates[i];
                    Template sourceTemplate = sourceTemplates.ElementAtOrDefault(i);

                    if (sourceTemplate == null)
                    {
                        continue;
                    }
                    //Merge Paramters
                    foreach (var parameter in sourceTemplate.Parameters)
                    {
                        if (!template.Parameters.ContainsKey(parameter.Key))
                        {
                            template.Parameters.Add(parameter.Key, parameter.Value);
                        }
                    }

                    // Merge resources
                    var resources = template.Resources.ToList();
                    resources.AddRange(sourceTemplate.Resources);

                    template.Resources = resources.ToArray();
                }
            }

            return templates;
        }

        public static List<Template> AddOrMergeRange(this List<Template> templates, Template sourceTemplates)
        {
            return AddOrMergeRange(templates, new List<Template>() { sourceTemplates });
        }
    }
}

