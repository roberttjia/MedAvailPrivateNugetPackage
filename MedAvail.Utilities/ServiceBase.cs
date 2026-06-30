using System;

namespace MedAvail.Utilities
{
    public abstract class ServiceBase<TRepository> where TRepository : class
    {
        protected TRepository Repository { get; }

        protected ServiceBase(TRepository repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        protected OperationResult<T> Success<T>(T value) =>
            OperationResult<T>.Ok(value);

        protected OperationResult<T> Failure<T>(string error) =>
            OperationResult<T>.Fail(error);

        protected void GuardPositive(decimal value, string parameterName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, "Value must be positive.");
        }

        protected void GuardNotNullOrEmpty(string? value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be null or empty.", parameterName);
        }
    }
}
