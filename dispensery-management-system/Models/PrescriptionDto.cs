namespace dispensery_management_system.Models
{
    public class PrescriptionDto
    {
        public string PrescriptionID { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string MedicinesPrescribed { get; set; } // This can be a simplified view (e.g., comma-separated)
        public string DosageInstructions { get; set; }
    }
}
