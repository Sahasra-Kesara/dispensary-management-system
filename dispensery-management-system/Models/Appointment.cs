using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Appointment
    {
        [Key]
        public string AppointmentID { get; set; }

        [ForeignKey("Patient")]
        public string PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public string DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan AppointmentTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // 'Scheduled', 'Completed', 'Canceled'

        public string Notes { get; set; }
    }
}
