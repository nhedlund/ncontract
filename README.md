# NContract - a design by contract library for .NET

NContract lets you write oneliners to verify parameters in constructors and methods instead of using more verbose if statements.

## Installation

Add the Nuget package NContract by using your IDE or through the terminal:

```bash
dotnet add package coverlet.msbuild
```
## Usage

To verify that a parameter is not null:
```csharp
Require.NotNull(parameter, nameof(parameter));
```

To verify that a parameter is not null or empty:
```csharp
Require.NotNullOrEmpty(parameter, nameof(parameter));
```

To verify that a parameter is not null or whitespace:
```csharp
Require.NotNullOrWhitespace(parameter, nameof(parameter));
```

To verify that a parameter is not empty:
```csharp
Require.NotEmpty(parameter, nameof(parameter));
```

To verify that a parameter value is true to a condition, for example >= 10:
```csharp
Require.True(parameter >= 10, "Parameter must be 10 or greater", nameof(parameter));
```
In addition to these requirement checks some have inverted checks as well: False, Null, Empty.

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.
