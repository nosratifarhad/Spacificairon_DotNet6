namespace Specification.Domain.Exceptions;

public class ValidatePasswordException : Exception
{
    public ValidatePasswordException() : base("Password Is Null Or Empty.")
    { }
}
