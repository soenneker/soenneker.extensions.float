using System;
using System.Diagnostics.Contracts;
using Soenneker.Extensions.Decimal;

namespace Soenneker.Extensions.Float;

/// <summary>
/// A collection of useful floating point extension methods
/// </summary>
public static class FloatExtension
{
    /// <summary>Shorthand for <code>Math.Round()</code> (after converting to decimal) </summary>
    /// <returns>The value converted to <see cref="decimal"/> and rounded to two fractional digits.</returns>
    [Pure]
    public static decimal ToCurrency(this float value)
    {
        return Convert.ToDecimal(value).ToCurrency();
    }
}