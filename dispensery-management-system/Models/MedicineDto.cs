namespace dispensery_management_system.Models
{
    public class MedicineDto
    {
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal PricePerUnit { get; set; }
    }
}
