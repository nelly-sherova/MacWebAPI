namespace MacWebApi.Models
{
    public class Category
    {
        /// <summary>
        ///     Идентификатор
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
        /// Продукты
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}
