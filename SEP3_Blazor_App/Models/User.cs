using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SEP3_Blazor_App.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string userId, string password)
        {
            UserId = userId;
            Password = password;
        }

        public User(string userid, string password,string role)
        {
            UserId = userid;
            Password = password;
            Role = role;
        }

        [Required(ErrorMessage = "CPR N0 is required")]
        [MaxLength(11, ErrorMessage = "Must not be less or greater than 10/11 characters")]
        [JsonPropertyName("userid")]
        public String UserId { get; set; }
        [Required]
        [JsonPropertyName("password")]
        public String Password { get; set; }
        [JsonPropertyName("role")]
        public String Role { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone Contact is required")]
        [JsonPropertyName("phonenb")]
        public string PhoneNb { get; set; }
    }
}