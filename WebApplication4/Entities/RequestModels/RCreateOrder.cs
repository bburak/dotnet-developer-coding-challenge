namespace WebApplication4.Entities.RequestModels
{
    public class RCreateOrder
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public string Category { get; set; }
    }
}
