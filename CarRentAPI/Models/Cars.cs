using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentAPI.Models
{
    [Table("cars")]
    public class Cars
    {
        public int Id { get; set; }
        public string Car_Name { get; set; }
        public string Car_Plate { get; set; }
        public string Car_Image { get; set; }
        public int Car_Status { get; set; }
    }
}
