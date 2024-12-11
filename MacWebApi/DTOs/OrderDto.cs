using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.DTOs
{
    public class OrderDto
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public required int Id { get; set; }
        /// <summary>
        /// Ориентир
        /// </summary>
        public required string? Landmark { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required string Street { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        [Range(1, 99999, ErrorMessage = "Номер дома должен быть в пределах от 1 до 99999.")]
        public required int House { get; set; }
        /// <summary>
        /// Квартира
        /// </summary>
        public required int? Apartment { get; set; }
        /// <summary>
        /// Оплачено? 
        /// </summary>
        public required bool IsPaid { get; set; }
        /// <summary>
        /// С собой?
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required bool IsToGo { get; set; }
        /// <summary>
        /// Внешний ключ города
        /// </summary>
        public required int CityId { get; set; }
        /// <summary>
        /// Внешний ключ для пользователя, который оформил заказ
        /// </summary>
        public required int CreatedByUserId { get; set; }
        /// <summary>
        /// Внешний ключ для пользователя, который подтвердил заказ
        /// </summary>
        public required int? ConfirmedByUserId { get; set; }
        /// <summary>
        /// Статус подстверждения заказа
        /// </summary>
        public int Status { get; set; }
    }
}
