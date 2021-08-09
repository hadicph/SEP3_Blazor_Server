using SEP3_Blazor_Server.Models;

namespace SEP3_Blazor_Server.Data.Services
{
    public class UserService : IUserService
    {
        public User ValidateUser(string username, string password)
        {
            User user = new User(username, password);
            return null;
        }
    }
}