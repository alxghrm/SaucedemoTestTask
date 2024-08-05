#### Playwright .NET Test 

<br>
Environment variables:<br>
Variables that need to be changed during pipeline runs should be defined in the 'appsettings.json' file.
<br>
<br>

Local testing:<br>
In order to run the tests on your machine the variables from the 'appsettings.json' file should be used in the
'secrets.json' file of the project and given the required values.

<br>
Test Reporting:

1. Test traces are located at bin\Debug\net8.0\playwright-traces and the zip files can we viewed at https://trace.playwright.dev/
2. Test videos are located at bin\Debug\net8.0\videos
