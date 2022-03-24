using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Product{ get; set; }
        public string Customer { get; set; }
        public string Category { get; set; }
        public string CargoName { get; set; }
        public short CargoStatus { get; set; }
    }
}
