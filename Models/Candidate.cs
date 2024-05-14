using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        // soru işareti koyduğumuzda null ifadesi olabilir anlamına gelir.
        // ctrl+alt+aşağı ok tuşuna bastığımızda cümlenin aynısını aşağı taşır.
        [Required(ErrorMessage = "E-mail is required.")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName is required.")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName is required.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}" ;
        public int? Age {get; set; } 
        public String?  SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        } 
    }
}