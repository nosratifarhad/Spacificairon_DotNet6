namespace Specification.Domain.Exceptions;

public class InValidateObjectException : Exception
{
    public InValidateObjectException(string objectName) : base($"{objectName} Is Not Be Null.")
    { }
}
