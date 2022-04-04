// --------------------------------------------------------------------------
//  <copyright file="CreateConsoleAppConfigurationCustom.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Commands.Configurations;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Constants;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Commands.Configurations
{
    [Verb(GlobalConstants.CreateName, HelpText = GlobalConstants.CreateDescription)]
    public class CreateConsoleAppConfigurationCustom : CreateConsoleAppConfiguration
    {
        [Option(longName: "outputLocation", HelpText = "Output location")]
        public string OutputLocation { get; set; }
    }
}
