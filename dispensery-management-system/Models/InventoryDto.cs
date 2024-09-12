namespace dispensery_management_system.Models
{
    public class InventoryDto
    {
        public string InventoryID { get; set; }
        public string MedicineID { get; set; }
        public int StockQuantity { get; set; }
        public DateTime LastRestockDate { get; set; }
    }
}
