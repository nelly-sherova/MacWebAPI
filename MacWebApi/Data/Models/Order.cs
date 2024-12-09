using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.Data.Models
{
    public class Order
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public int Id { get; set; }
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
        /// С собой?
        /// </summary>
        public bool IsToGo { get; set; }
        /// <summary>
        /// Продукты
        /// </summary>
        public ICollection<Product> Products { get; set; }
        /// <summary>
        /// Внешний ключ города
        /// </summary>
        [ForeignKey("CityId")]
        public int CityId { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public City City { get; set; }
        /// <summary>
        /// Внешний ключ для пользователя, который оформил заказ
        /// </summary>
        [ForeignKey("CreatedByUserId")]
        public int CreatedByUserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User CreatedByUser { get; set; }
        /// <summary>
        /// Внешний ключ для пользователя, который подтвердил заказ
        /// </summary>
        [ForeignKey("ConfirmedByUserId")]
        public int? ConfirmedByUserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User? ConfirmedByUser { get; set; }
        /// <summary>
        /// Статус подстверждения заказа
        /// </summary>
        public bool IsConfirmed { get; set; }
        /// <summary>
        /// Дата и время регистации заказа
        /// </summary>
        public DateTime DateCreate { get; set; }
        /// <summary>
        /// Дата и время подтверждения заказа
        /// </summary>
        public DateTime DateConfirmed { get; set; }
        /// <summary>
        /// Дата и время доставки заказа
        /// </summary>
        public DateTime? DateOfDelivery {get; set;}
        /// <summary>
        /// Статус доставки товара 
        /// </summary>
        public bool IsDelivery { get; set; }
    }
}
