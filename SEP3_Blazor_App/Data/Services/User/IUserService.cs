using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_Blazor_App.Models;

namespace SEP3_Blazor_App.Data.Services.User
{
    public interface IUserService
    {
        Task<Models.User> ValidateUser(string userid, string password);
        Task<List<Models.User>> GetAllUsers();
        Task<bool> DeleteUser(string userid);
        Task<List<Case>> GetCasesForSpecificUser(string userid);
    }
}