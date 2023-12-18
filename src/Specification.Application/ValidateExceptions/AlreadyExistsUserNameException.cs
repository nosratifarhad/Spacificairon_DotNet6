namespace Specification.Domain.Exceptions;

public class AlreadyExistsUserNameException : Exception
{
    public AlreadyExistsUserNameException(string userName) : base($"{userName} Is Already Exists.")
    { }
}
