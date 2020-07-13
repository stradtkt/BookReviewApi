using System;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public User()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}