namespace MacWebApi.Data.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
