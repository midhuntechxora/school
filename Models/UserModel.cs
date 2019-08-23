using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace school.Models
{
    public class UserModel 
    {
       public string UserName { get; set; }
       public string Email { get; set; }
       public string Password { get; set; }
       public string FullName { get; set; }

    }
}