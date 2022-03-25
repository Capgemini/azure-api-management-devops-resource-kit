
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace ArmTemplates.Custom.Common.Templates.Abstractions
{
    public class TemplateParameterPropertiesCustom : TemplateParameterProperties
    {
        public new string value { get; set; }
    }
}
