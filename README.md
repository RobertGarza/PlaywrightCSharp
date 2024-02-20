## Important Scripts



#### Running the Debugger - locator finder:

pwsh bin/Debug/net8.0/playwright.ps1 codegen "webpage here and take out the commas"

##### Running the HTML:

livingdoc test-assembly bin/Debug/net8.0/PlaywrightSISHARP.dll -t bin/Debug/net8.0/TestExecution.json --title "guru99 Automation Report" --output ./report/index.html


## Installers

- LivingDoc: dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
- PowerShell: dotnet tool install --global PowerShell

    download dotnet 8.0 from:[https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

    helpers to create app: https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-8-0

## Runners

- run one: dotnet test --filter "@feature"
- run all: dotnet test
