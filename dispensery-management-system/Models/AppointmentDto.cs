namespace dispensery_management_system.Models
{
    public class AppointmentDto
    {
        public string AppointmentID { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string Status { get; set; } // 'Scheduled', 'Completed', 'Canceled'
        public string Notes { get; set; }
    }
}
