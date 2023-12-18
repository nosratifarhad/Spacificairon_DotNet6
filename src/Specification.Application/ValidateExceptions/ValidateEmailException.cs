namespace Specification.Domain.Exceptions;

public class ValidateEmailException : Exception
{
    public ValidateEmailException() : base("Email Is Null Or Empty.")
    { }
}
