using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.Models
{
    public class Product
    {
        /// <summary>
        /// Идентификатор
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
        /// Основная цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Прежняя цена
        /// </summary>
        public decimal? OldPrice { get; set; }   
        /// <summary>
        /// Процент скидки 
        /// </summary>
        public decimal? SalePersent { get; set; }
        /// <summary>
        /// Внешний ключ 
        /// </summary>
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        /// <summary>
        /// Категория продукта
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Внешний ключ для связи заказа и продуктов
        /// </summary>
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }    
        /// <summary>
        /// Заказ 
        /// </summary>
        public Order Order { get; set; }


    }
}
