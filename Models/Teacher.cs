using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace school.Models
{
    public class Teacher
    {
        private const string nv = "nvarchar(100)";

        [Key]
        public long Id { get; set; }
        [Required]
        [Column(TypeName = nv)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = nv)]
        public string HashName { get; set; }

    }
}