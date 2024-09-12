namespace dispensery_management_system.Models
{
    public class PatientDto
    {
        public string PatientID { get; set; }
        public string UserID { get; set; } // Associated UserProfile
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string AllergyInfo { get; set; }
        public string MedicalHistory { get; set; }
    }
}
