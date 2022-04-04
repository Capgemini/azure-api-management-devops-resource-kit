// --------------------------------------------------------------------------
//  <copyright file="GlobalConstants.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Common.Constants
{
    public static class GlobalConstants
    {
        public static class ParameterNames
        {
            public const string ApiLoggerId = "apiLoggerId";
            public const string NamedValues = "namedValues";
            public const string LoggerResourceId = "loggerResourceId";
            public const string ServiceUrl = "serviceUrl";
            public const string PolicyXMLSasToken = "policyXMLSasToken";
            public const string PolicyXMLBaseUrl = "policyXMLBaseUrl";
            public const string LinkedTemplatesUrlQueryString = "linkedTemplatesUrlQueryString";
            public const string LinkedTemplatesSasToken = "linkedTemplatesSasToken";
            public const string ApimServiceName = "apimServiceName";
            public const string LinkedTemplatesBaseUrl = "linkedTemplatesBaseUrl";
            public const string NamedValueKeyVaultSecrets = "namedValueKeyVaultSecrets";
            public const string BackendSettings = "backendSettings";
            public const string LoggerName = "loggerName";
        }
    }
}
