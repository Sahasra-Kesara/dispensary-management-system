using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Patient
    {
        [Key]
        public string PatientID { get; set; }

        [ForeignKey("UserProfile")]
        public string UserID { get; set; }
        public UserProfile UserProfile { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        [StringLength(5)]
        public string BloodGroup { get; set; }

        public string AllergyInfo { get; set; }
        public string MedicalHistory { get; set; }
    }
}
