using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.Data.Models
{
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Связь пользователя с его ролью
        /// </summary>
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// Список созданных заказов пользователя
        /// </summary>
        public ICollection<Order> CreatedOrders { get; set; }
        /// <summary>
        /// Список подтвержденных заказов пользователя
        /// </summary>
        public ICollection<Order> ConfirmedOrders { get; set; }
    }
}
