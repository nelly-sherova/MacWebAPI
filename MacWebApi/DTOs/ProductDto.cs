using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.DTOs
{
    public class ProductDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public required int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Основная цена
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required decimal Price { get; set; }
        /// <summary>
        /// Прежняя цена
        /// </summary>
        public required decimal? OldPrice { get; set; }
        /// <summary>
        /// Процент скидки 
        /// </summary>
        public required decimal? SalePersent { get; set; }
        /// <summary>
        /// Внешний ключ 
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required int CategoryId { get; set; }
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required int OrderId { get; set; }
    }
}
