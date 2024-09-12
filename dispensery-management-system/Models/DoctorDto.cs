namespace dispensery_management_system.Models
{
    public class DoctorDto
    {
        public string DoctorID { get; set; }
        public string UserID { get; set; } // Associated UserProfile
        public string Specialization { get; set; }
        public int ExperienceYears { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}
