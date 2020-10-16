using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManager.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(50), Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [NotMapped]
        public string Name => FirstName + " " + LastName;
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Street { get; set; }
        [Required]
        public int StreetNumber { get; set; }
        [Required, DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
    }
}