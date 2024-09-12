using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace dispensery_management_system.Models
{
    public class UserProfile
    {
        [Key]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required]
        public string UserType { get; set; } // 'Admin', 'Doctor', 'Staff', 'Patient'

        [Required]
        public string Password { get; set; }

        public string Address { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
