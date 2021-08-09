using SEP3_Blazor_Server.Models;

namespace SEP3_Blazor_Server.Data.Services
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}