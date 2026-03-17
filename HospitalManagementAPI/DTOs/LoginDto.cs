using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.DTO
{
    public class DoctorLoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}