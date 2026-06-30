namespace MedAvail.Utilities
{
    public interface IValidator<in T>
    {
        ValidationResult Validate(T entity);
    }
}
