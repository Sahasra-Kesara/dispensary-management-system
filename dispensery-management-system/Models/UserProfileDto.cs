using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class UserProfileDto
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; } // 'Admin', 'Doctor', 'Staff', 'Patient'
        [Required]
        public string Password { get; set; }  // Add this field to the DTO
        public string Address { get; set; }
    }
}