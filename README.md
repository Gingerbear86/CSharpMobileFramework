# CSharpMobileFramework

This project contains automated test scripts for testing the quasar.dev website using Selenium and Appium. The scripts are designed to perform various interactions and validations on the mobile version of the website.

Prerequisites

.NET SDK
NUnit
NLog
Selenium WebDriver
Appium.WebDriver

Installation

Clone or download this repository to your local machine.
Open the project in your preferred IDE, such as Visual Studio.
Restore NuGet packages to ensure all dependencies are downloaded.

Configuration

Configure the testconfig.json file with appropriate URLs, binary locations, and driver paths for the Mobile configuration.
{
  "Mobile": {
    "Url": "https://quasar.dev/",
    "BinaryLocation": "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
    "DriverPath": "C:\\Coding\\Automation Learning\\QuasarAutomation\\"
  }
}
Adjust the configuration settings as per your environment.

Usage

Open a terminal and navigate to the project directory.
Run the tests using the following command:
dotnet test
The tests will be executed, and the test outcomes will be logged using NLog.

Project Structure

QuasarAutomation.MobileHomePage: Contains page classes for interacting with the mobile homepage.
QuasarAutomation.MobileDocsPage: Contains page classes for interacting with the mobile documentation page.
QuasarAutomation.MobileTablesPage: Contains page classes for interacting with mobile tables (work in progress).

Acknowledgments

The code in this repository were created with a little help from Chat GPT by Jonathan Howard, an aspiring software developer with expertise in Agile Software Development and proficiency in various programming languages.
QuasarAutomation.MobileUtils: Contains utilities and driver setup for mobile automation.
QuasarAutomation.MobileQuasarTestSuite: Contains test cases written using NUnit framework.
Logging
Test outcomes and error messages are logged using NLog. The log file is generated in the project directory with the name NLogLog.log.
