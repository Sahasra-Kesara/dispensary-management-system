using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Prescription
    {
        [Key]
        public string PrescriptionID { get; set; }

        [ForeignKey("Patient")]
        public string PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public string DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        [DataType(DataType.Date)]
        public DateTime PrescriptionDate { get; set; }

        public string MedicinesPrescribed { get; set; } // Can be JSON or comma-separated string

        public string DosageInstructions { get; set; }
    }
}
