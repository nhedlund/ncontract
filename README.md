# NContract - a design by contract library for .NET

[![Build Status](https://dev.azure.com/orisoft/ncontract/_apis/build/status/nhedlund.ncontract?branchName=master)](https://dev.azure.com/orisoft/ncontract/_build/latest?definitionId=4?branchName=master)

NContract lets you write one-liners to verify parameters in constructors and methods instead of using more verbose if statements.

## Installation

Add the Nuget package NContract by using your IDE or through the terminal:

```bash
dotnet add package NContract
```

## Usage

### Null checks

To verify that a parameter is not null:
```csharp
Require.NotNull(parameter, nameof(parameter));
```

To verify that a parameter is null:
```csharp
Require.Null(parameter, nameof(parameter));
```

### Strings

To verify that a parameter is not null or empty:
```csharp
Require.NotNullOrEmpty(parameter, nameof(parameter));
```

To verify that a parameter is not null or whitespace:
```csharp
Require.NotNullOrWhitespace(parameter, nameof(parameter));
```

### True or false conditions

To verify that a parameter value is true to a condition, for example >= 10:
```csharp
Require.True(parameter >= 10, "Parameter must be 10 or greater", nameof(parameter));
```

To verify that a parameter value is false to a condition, for example >= 10:
```csharp
Require.False(parameter >= 10, "Parameter must be 9 or less", nameof(parameter));
```

### Collections 

To verify that a parameter is not empty:
```csharp
Require.NotEmpty(parameter, nameof(parameter));
```

To verify that a parameter is empty:
```csharp
Require.Empty(parameter, nameof(parameter));
```

To verify that a parameter value has at least one element satisfying a predicate, for example >= 10:
```csharp
Require.Any(parameter, v => v >= 10, "At least one parameter element must be 10 or greater", nameof(parameter));
```

To verify that all parameter values satisfies a predicate, for example >= 10:
```csharp
Require.All(parameter, v => v >= 10, "All parameter elements must be 10 or greater", nameof(parameter));
```

To verify that no parameter values matches a predicate, for example >= 10:
```csharp
Require.None(parameter, v => v >= 10, "No parameter elements can be 10 or greater", nameof(parameter));
```

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.
