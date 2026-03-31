# Project Add 2 numbers

This solution contains 3 projects:

- `Project Add 2 numbers`: class library that contains `MyBigNumber`
- `Project Add 2 numbers.App`: console app used to run and debug the class library
- `Project Add 2 numbers.Tests`: xUnit test project

## Open the solution

Open:

```text
Project Add 2 numbers.sln
```

## Run the class library

Run with the default sample values:

```powershell
dotnet run --project ".\Project Add 2 numbers.App\Project Add 2 numbers.App.csproj"
```

## Run the tests

Run all tests in the test project:

```powershell
dotnet test ".\Project Add 2 numbers.Tests\Project Add 2 numbers.Tests.csproj"
```

## Build the projects

Build the app project:

```powershell
dotnet build ".\Project Add 2 numbers.App\Project Add 2 numbers.App.csproj"
```

Build the test project:

```powershell
dotnet build ".\Project Add 2 numbers.Tests\Project Add 2 numbers.Tests.csproj"
```

## Notes

- `MyBigNumber` receives `ILogger<MyBigNumber>` through constructor injection.
- Logging is configured in the console app project.
- The tests focus on verifying the sum result.
