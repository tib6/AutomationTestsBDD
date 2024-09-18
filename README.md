C# NUnit SpecFlow Selenium Template Project

Overview

This is a Selenium automation testing template project that uses NUnit as the testing framework and SpecFlow for behavior-driven development (BDD). It is intended to serve as a template for writing end-to-end UI tests in C#. The project integrates the following tools and libraries:

NUnit: Unit testing framework for C#.

SpecFlow: BDD framework for writing human-readable tests.

Selenium WebDriver: Browser automation tool.

ExtentReports: Reporting library for generating HTML reports.

This template allows for easy creation of BDD-style automated tests, making it ideal for UI test automation of web applications.


Prerequisites

Before you can run the tests, ensure that you have the following installed:

Visual Studio (or any other C# IDE)

.NET SDK (6.0 or later)

NuGet (for managing packages)

Tools and Libraries

The project uses the following libraries, installed via NuGet:

Selenium.WebDriver: Browser automation for web applications.

Selenium.WebDriver.ChromeDriver: WebDriver for automating Chrome.

SpecFlow: Framework for BDD-style tests.

NUnit: Unit testing framework.

SpecFlow.NUnit: Adapter for using SpecFlow with NUnit.

ExtentReports: Library for generating reports.

Microsoft.Extensions.DependencyInjection: For dependency injection (optional but recommended).

  <ItemGroup>
    <PackageReference Include="ExtentReports" Version="4.1.0" />
    <PackageReference Include="FluentAssertions" Version="6.12.1" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1" />
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
    <PackageReference Include="NUnit" Version="3.13.1" />
    <PackageReference Include="NUnit3TestAdapter" Version="4.6.0" />
    <PackageReference Include="Selenium.WebDriver" Version="3.13.1" />
    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="129.0.6668.5800" />
    <PackageReference Include="SpecFlow.NUnit" Version="3.9.74" />
    <PackageReference Include="SpecFlow.Plus.LivingDocPlugin" Version="3.9.57" />
  </ItemGroup>
