using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

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
        public int? TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        public virtual ICollection<StudentLesson> StudentLessons { get; set; }
    }
}