[![](https://img.shields.io/nuget/v/Soenneker.Extensions.Float.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Extensions.Float/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.float/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.float/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Extensions.Float.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Extensions.Float/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.float/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.float/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Float
Extension methods for rounding, converting, formatting, and otherwise working with single-precision floating-point values.

## Installation

```bash
dotnet add package Soenneker.Extensions.Float
```

## Usage

```csharp
using Soenneker.Extensions.Float;

decimal amount = 19.995f.ToCurrency(); // 20.00m
```

`ToCurrency()` first uses `Convert.ToDecimal(float)`, then rounds that decimal value to two fractional digits with midpoint-to-even (banker's) rounding. The result is a number, not a formatted string—it does not add a currency symbol or thousands separators.

The initial conversion can reflect the precision already lost in the binary `float`; this method cannot recover the original decimal input. NaN, positive infinity, and negative infinity cannot be converted to `decimal` and throw `OverflowException`.
