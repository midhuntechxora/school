using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace school.Models
{
    public class User : IdentityUser
    {
        [Column(TypeName="nvarchar(150)")]
        public string FullName { get; set; }

    }
}