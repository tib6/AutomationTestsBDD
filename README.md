C# NUnit SpecFlow Selenium Template Project

Overview

This is a Selenium automation testing template project that uses NUnit as the testing framework and SpecFlow for behavior-driven development (BDD). It is intended to serve as a template for writing end-to-end UI tests in C#.

Before you can run the tests, ensure that you have the following installed: Visual Studio (or any other C# IDE); .NET SDK (6.0 or later); NuGet (for managing packages)

Tools and Libraries - > The project uses the following libraries, installed via NuGet:

1. Newtonsoft.Json (Version=13.0.3)
Description: Newtonsoft.Json (also known as Json.NET) is a popular high-performance JSON framework for .NET. It is commonly used to handle JSON serialization and deserialization, which allows you to easily convert objects to JSON and vice versa.
Use Case: If your tests involve interacting with APIs, reading configurations from JSON files, or handling test data in JSON format, this library will help you parse and generate JSON.
2. NUnit (Version=3.13.1)
Description: NUnit is a widely used testing framework for all .NET languages. It allows you to write unit tests and execute them as part of your test suite.
Use Case: This forms the core of your test execution. It is the framework under which your SpecFlow scenarios are executed, and it provides features like assertions, test fixtures, and test runners.
3. NUnit3TestAdapter (Version=4.6.0)
Description: This is an adapter that allows NUnit tests to be discovered, executed, and reported in Visual Studio’s Test Explorer. It integrates NUnit with Visual Studio's built-in testing tools.
Use Case: This allows you to run and debug your NUnit tests directly within Visual Studio using the Test Explorer window.
4. Selenium.WebDriver (Version=3.13.1)
Description: Selenium WebDriver is the main tool used for automating browser interactions. It is a web automation framework that enables you to programmatically interact with web pages by driving browsers like Chrome, Firefox, and others.
Use Case: Selenium WebDriver is used to perform the actual browser automation, such as opening web pages, interacting with web elements, filling out forms, clicking buttons, and verifying results.
5. Selenium.WebDriver.ChromeDriver (Version=129.0.6668.5800)
Description: ChromeDriver is a standalone server that implements the WebDriver protocol for Google Chrome. It is required to run Selenium tests on the Chrome browser.
Use Case: This package provides the necessary driver to allow Selenium to control and automate Google Chrome. Make sure the version of ChromeDriver matches your Chrome browser version.
6. SpecFlow.NUnit (Version=3.9.74)
Description: SpecFlow is a framework that brings Behavior-Driven Development (BDD) to .NET. This package integrates SpecFlow with NUnit, allowing you to run SpecFlow scenarios using NUnit's testing framework.
Use Case: This package allows you to define your tests in Gherkin syntax (Given, When, Then), making them more readable and user-friendly. SpecFlow turns these human-readable Gherkin steps into executable NUnit tests.
7. SpecFlow.Plus.LivingDocPlugin (Version=3.9.57)
Description: SpecFlow.Plus.LivingDocPlugin is a plugin for generating Living Documentation from your SpecFlow feature files. It creates dynamic reports that show the current status of your feature files and test results.
Use Case: This plugin allows you to automatically generate reports (Living Documentation) that visualize the execution results of your SpecFlow scenarios, which is useful for reporting purposes and keeping your BDD documentation in sync with test execution.

These packages together provide the foundation for automating UI testing using Selenium, running the tests using NUnit, defining tests in a BDD format via SpecFlow, and generating detailed reports.
