using System.Collections.Generic;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Creator.Models;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Creator.Models
{
    public class CreatorConfigCustom: CreatorConfig
    {
            public List<TemplateParatrerConfig> templateParameters { get; set; }
    }
}
