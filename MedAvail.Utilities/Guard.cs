using System;

namespace MedAvail.Utilities;

public static class Guard
{
    public static T NotNull<T>(T? value, string parameterName) where T : class
    {
        if (value is null)
            throw new ArgumentNullException(parameterName);
        return value;
    }

    public static string NotNullOrEmpty(string? value, string parameterName)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Value cannot be null or empty.", parameterName);
        return value;
    }

    public static int Positive(int value, string parameterName)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(parameterName, "Value must be positive.");
        return value;
    }
}
