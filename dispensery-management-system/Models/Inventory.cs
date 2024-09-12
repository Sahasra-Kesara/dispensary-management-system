using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dispensery_management_system.Models
{
    public class Inventory
    {
        [Key]
        public string InventoryID { get; set; }

        [ForeignKey("Medicine")]
        public string MedicineID { get; set; }
        public Medicine Medicine { get; set; }

        public int StockQuantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastRestockDate { get; set; }
    }
}
