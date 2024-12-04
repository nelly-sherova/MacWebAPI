using System.ComponentModel.DataAnnotations;

namespace MacWebApi.DTOs
{
    public class CategoryDto
    {
        /// <summary>
        /// Иденитификатор
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
        public required string? Description { get; set; }

    }
}
