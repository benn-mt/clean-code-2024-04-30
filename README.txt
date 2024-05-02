# Clean Code 2024-04-30

## Project creation

dotnet new sln
dotnet new console -n CleanCode
dotnet sln add CleanCode
dotnet new nunit -n CleanCode.Test
dotnet sln add CleanCode.Test
dotnet add ./CleanCode.Test/CleanCode.Test.csproj reference ./CleanCode/CleanCode.csproj

To Test: 

`dotnet test`

## Code Coverage
We have installed Coverlet

cd CleanCode.Test
dotnet add package coverlet.collector
dotnet add package coverlet.msbuild

To collect coverage

dotnet test --collect:"XPlat Code Coverage"

This will generate a coverage.cobertura.xml in the CleanCode/Test/TestResults directory

dotnet test /p:CollectCoverage=true

Will show a summary in the console.