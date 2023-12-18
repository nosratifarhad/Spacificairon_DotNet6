namespace Specification.Domain.Exceptions;

public class ValidateFirstNameException : Exception
{
    public ValidateFirstNameException() : base("FirstName Is Null Or Empty.")
    { }
}
