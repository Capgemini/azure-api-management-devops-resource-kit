
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.FileHandlers;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Custom.Common.FileHandlers
{
    public static class MergeTemplatesFileNameGenerator
    {
        public static string GenerateCreatorAPIFileName(string apiName, bool isSplitAPI, bool isInitialAPI)
        {
            // in case the api name has been appended with ;rev={revisionNumber}, take only the api name initially provided by the user in the creator config
            string sanitizedAPIName = FileNameGenerator.GenerateOriginalAPIName(apiName);

            if (isSplitAPI == true)
            {
                return isInitialAPI == true ? $@"/{sanitizedAPIName}-operations.json" : $@"/{sanitizedAPIName}-properties.json";
            }
            else
            {
                return $@"/{sanitizedAPIName}.json";
            }
        }
    }
}
