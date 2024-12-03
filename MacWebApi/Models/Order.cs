namespace MacWebApi.Models
{
    public class Order
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Город
        /// </summary>
        public string  City { get; set; }   
        /// <summary>
        /// Ориентир
        /// </summary>
        public string? Landmark { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }  
        /// <summary>
        /// Дом
        /// </summary>
        public int House { get; set; } 
        /// <summary>
        /// Квартира
        /// </summary>
        public int? Apartment { get; set; }  
        /// <summary>
        /// Оплачено? 
        /// </summary>
        public bool IsPaid { get; set; }    
        /// <summary>
        /// Продукты
        /// </summary>
        public ICollection<Product> Products { get; set; }  

    }
}
