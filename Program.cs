using System;
using System.Runtime.CompilerServices;
using Hl7.Fhir.Rest;
namespace smart_local
{
    public static class Program
    {
        private const string DefaultFhirServerUrl ="https://launch.smarthealthit.org/v/r3/sim/WzIsIiIsInNtYXJ0LVByYWN0aXRpb25lci03MTA4MTMzMiIsIkFVVE8iLDAsMCwwLCIiLCIiLCIiLCIiLCIiLCIiLCIiLDAsMSwiIl0/fhir";

        // Valid entry point
        public static int Main(string fhirServerUrl )
        {
            // Use the first arg if provided; otherwise fall back to the default
            if (string.IsNullOrWhiteSpace(fhirServerUrl)) {
                fhirServerUrl = DefaultFhirServerUrl;
            }
                
            Console.WriteLine($"FHIR Server: {fhirServerUrl}\n");

            FhirClient fhirClient = new FhirClient(fhirServerUrl);

            if (!FhirUtils.GetSmartUrls(fhirClient, out string authorizeUrl, out string tokenUrl))
            {
                Console.WriteLine("Failed to Discover SMART URLS\n");
                return -1;
            }
            Console.WriteLine($"Authorize URL: {authorizeUrl}\n");
            Console.WriteLine($"Token URL: {tokenUrl}\n");
        
            return 0;
        }
    }
}
