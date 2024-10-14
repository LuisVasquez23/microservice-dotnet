using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentService.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Email { get; set; }
        public int UniversityId {  get; set; }
        public University? University { get; set; }
    }
}
