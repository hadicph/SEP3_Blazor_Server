using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SEP3_Blazor_Server.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;

        }

        [Required]
        [JsonPropertyName("username")]
        public String UserName { get; set; }
        [Required]
        [JsonPropertyName("password")]
        public String Password { get; set; }
        [JsonPropertyName("role")]
        public String Role { get; set; }
        
        
        // public int Id { get; set; }
        // [Required(ErrorMessage = "CPR N0 is required")]
        // [MaxLength(11, ErrorMessage = "Must not be less or greater than 10/11 characters")]
        // public string userId { get; set; }
        // [Required(ErrorMessage = "First Name is required")]
        // public string firstName { get; set; }
        // [Required(ErrorMessage = "Last Name is required")]
        // public string lastName { get; set; }
        // [Required]
        // [DataType(DataType.EmailAddress)]
        // [EmailAddress]
        // public string emailAddress { get; set; }
        // [Required(ErrorMessage = "Password is required")]
        // [MinLength(6, ErrorMessage = "Password Minimum length must be 6")]
        // public string password { get; set; }
        // [Required(ErrorMessage = "Phone Contact is required")]
        // public string contact { get; set; }
        // public string gender { get; set; }
        // [Required(ErrorMessage = "Address is required")]
        // public string address { get; set; }
        // public string dept { get; set; }
        // public string doctorId { get; set; }
        // public string symptoms { get; set; }
        // public string status { get; set; }
        // public string token { get; set; }
        // public string role { get; set; }
        
        
    }
}