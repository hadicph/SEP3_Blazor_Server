using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3_Blazor_App.Models;

namespace SEP3_Blazor_App.Data.Services.User
{
    public class UserService : IUserService
    {
        private HttpClient Client;
        private String Uri;

        public UserService()
        {
            Client =  new HttpClient();
            Uri = "http://localhost:8080";
        }
        public async Task<Models.User> ValidateUser(string userid, string password)
        {
            Models.User user = new Models.User(userid, password);
            StringContent content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/login",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                Models.User validateUser = JsonSerializer.Deserialize<Models.User>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return validateUser;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
            
        }

        public async Task<List<Models.User>> GetAllUsers()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/users");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync(); 
                List<Models.User> userList = JsonSerializer.Deserialize<List<Models.User>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return userList;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }

        }

        public async Task<bool> DeleteUser(string userid)
        {
            HttpResponseMessage responseMessage = await Client.DeleteAsync(Uri + "/user/" + userid );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                bool response = JsonSerializer.Deserialize<bool>(result, new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return response;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<List<Case>> GetCasesForSpecificUser(string userid)
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/cases/" + userid);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync(); 
                List<Case> caseList = JsonSerializer.Deserialize<List<Case>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return caseList;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}