using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityService.Models
{
    [Table("Universities")]
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Address { get; set; }

    }
}
