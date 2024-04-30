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