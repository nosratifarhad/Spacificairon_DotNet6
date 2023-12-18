using Specification.Domain.User.Entities;

namespace Specification.Application.DTOs;

public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailId { get; set; }
    public int Status { get; set; }
    public string StatusText { get; set; }

    public UserDto(UserBase user)
    {
        Id = user.Id;
        FirstName = user.FirstName;
        LastName = user.LastName;
        EmailId = user.Email;
        Status = (int)user.Status;
        StatusText = user.Status.ToString();
    }
}