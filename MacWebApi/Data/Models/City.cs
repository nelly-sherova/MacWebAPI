namespace MacWebApi.Data.Models
{
    public class City
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Заказы связанные с этим городом
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
