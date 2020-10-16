using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManager.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Location { get; set; }
        
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        public ICollection<StudentLesson> StudentLessons { get; set; }
    }
}