// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Creator.Models
{
    public class TemplateParatrerConfig: TemplateParameterProperties
    {
        public string name { get; set; }

        public Dictionary<string,string> values { get; set; }
    }
}
