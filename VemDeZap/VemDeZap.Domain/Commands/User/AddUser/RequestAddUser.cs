using MediatR;

namespace VemDeZap.Domain.Commands.User.AddUser
{
    public class RequestAddUser : IRequest<Response>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
