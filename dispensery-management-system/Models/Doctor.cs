using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Doctor
    {
        [Key]
        public string DoctorID { get; set; }

        [ForeignKey("UserProfile")]
        public string UserID { get; set; }
        public UserProfile UserProfile { get; set; }

        [Required]
        [StringLength(100)]
        public string Specialization { get; set; }

        public int ExperienceYears { get; set; }

        [DataType(DataType.Currency)]
        public decimal ConsultationFee { get; set; }
    }
}
