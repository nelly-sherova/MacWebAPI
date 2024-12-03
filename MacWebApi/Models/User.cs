using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.Models
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
        public Role Role { get; set; }
    }
}
