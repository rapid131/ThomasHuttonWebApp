using System.ComponentModel.DataAnnotations;
namespace ThomasHuttonWebApp.Components.Classes
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Company is required.")]
        [StringLength(25, ErrorMessage = "Company name must be less than 25 characters.")]
        public string Company { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(15, ErrorMessage = "First name must be less than 15 characters.")]
        public string Name { get; set; }
        public DateTime Datesigned { get; set; }

    }
}
