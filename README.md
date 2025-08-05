# DEVELOPING AN API IN SMART FHIR STU3 V3.1.0 ON WINDOWS - PART 3

This is a tutorial in how to access SMART FHIR servers via C# and .Net Core with a local webserver for redirection.^

## Needed Tools

For developing this part of the project it will be needed the same tools as the previous projects present in:

- [**Part 1 :**](https://github.com/orlandonss/HL7-FHIR)
  How to create a project from scratch.
- [**Part 2 :**](https://github.com/orlandonss/HL7-FHIR-2)
  How to create a local Fhir server  from scratch using a docker.

## Nuget packages

A curated list of required packages with versions and direct NuGet links.  
Easily add them to your project using `dotnet add package`.

### 🏥 HL7 FHIR
- **[Hl7.Fhir.R4](https://www.nuget.org/packages/Hl7.Fhir.Support/3.1.0)**  
  ```bash
  dotnet add package Hl7.Fhir.STU3 --version 3.1.0
  dotnet add package Hl7.Fhir.STU3.Specification --version 3.1.0
  ```

### 🌐 ASP.NET Core
- **[Microsoft.AspNetCore.App](https://www.nuget.org/packages/Microsoft.AspNetCore.App/2.2.8)**  
  ```bash
  dotnet add package Microsoft.AspNetCore.App --version 2.2.8
  ```

- **[Microsoft.AspNetCore.Cors](https://www.nuget.org/packages/Microsoft.AspNetCore.Cors/2.2.0)**  
  ```bash
  dotnet add package Microsoft.AspNetCore.Cors --version 2.2.0
  ```

- **[Microsoft.AspNetCore.Razor.Design](https://www.nuget.org/packages/Microsoft.AspNetCore.Razor.Design/2.2.0)**  
  ```bash
  dotnet add package Microsoft.AspNetCore.Razor.Design --version 2.2.0
  ```

### ⚙️ Configuration
- **[Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/3.1.9)**  
  ```bash
  dotnet add package Microsoft.Extensions.Configuration --version 3.1.9
  ```

- **[Microsoft.Extensions.Configuration.EnvironmentVariables](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.EnvironmentVariables/3.1.9)**  
  ```bash
  dotnet add package Microsoft.Extensions.Configuration.EnvironmentVariables --version 3.1.9
  ```

- **[Microsoft.Extensions.Configuration.Json](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/3.1.9)**  
  ```bash
  dotnet add package Microsoft.Extensions.Configuration.Json --version 3.1.9
  ```

### 💻 CLI Tools
- **[System.CommandLine.DragonFruit](https://www.nuget.org/packages/System.CommandLine.DragonFruit/0.3.0-alpha.20371.2)**  
  ```bash
  dotnet add package System.CommandLine.DragonFruit --version 0.3.0-alpha.20371.2
  ```
