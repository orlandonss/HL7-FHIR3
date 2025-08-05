using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;

namespace smart_local
{
    /// <summary>
    /// FHIR Utility functions
    /// </summary>
    public static class FhirUtils
    {
        public static bool GetSmartUrls(FhirClient fhirClient, out string authorizeUrl, out string tokenUrl)
        {
            authorizeUrl = string.Empty;
            tokenUrl = string.Empty;

            CapabilityStatement capabilities = (CapabilityStatement)fhirClient.Get("metadata");

            foreach (CapabilityStatement.RestComponent restComponent in capabilities.Rest)
            {
                if (restComponent.Security == null)
                {
                    continue;
                }

                foreach (Extension securityExt in restComponent.Security.Extension)
                {
                    if (securityExt.Url != "http://fhir-registry.smarthealthit.org/StructureDefinition/oauth-uris")
                    {
                        continue;
                    }

                    if (securityExt.Extension == null || securityExt.Extension.Count == 0)
                    {
                        continue;
                    }

                    foreach (Extension smartExtension in securityExt.Extension)
                    {
                        switch (smartExtension.Url)
                        {
                            case "authorize":
                                authorizeUrl = ((FhirUri)smartExtension.Value).ToString();
                                break;

                            case "token":
                                tokenUrl = ((FhirUri)smartExtension.Value).ToString();
                                break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(authorizeUrl) && !string.IsNullOrEmpty(tokenUrl))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
