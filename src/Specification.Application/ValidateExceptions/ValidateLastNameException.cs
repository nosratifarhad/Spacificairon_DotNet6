namespace Specification.Domain.Exceptions;

public class ValidateLastNameException : Exception
{
    public ValidateLastNameException() : base("LastName Is Null Or Empty.")
    { }
}
