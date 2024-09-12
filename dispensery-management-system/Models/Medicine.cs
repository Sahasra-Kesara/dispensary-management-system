using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Medicine
    {
        [Key]
        public string MedicineID { get; set; }

        [Required]
        [StringLength(100)]
        public string MedicineName { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal PricePerUnit { get; set; }
    }
}
