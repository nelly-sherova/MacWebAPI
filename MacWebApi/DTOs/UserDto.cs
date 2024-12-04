using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacWebApi.DTOs
{
    public class UserDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public required int Id { get; set; }
        /// <summary>
        /// Фамилия 
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required string FirstName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required string LastName { get; set; }
        /// <summary>
        /// Отчество 
        /// </summary>
        public required string? MiddleName { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        [EmailAddress(ErrorMessage = "Неверный формат email.")]
        public required string Email { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>  
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        public required string Password { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        [Required(ErrorMessage = "Параметр {0} не заполнено")]
        [RegularExpression(@"^\+992\d{9}$", ErrorMessage = "Номер телефона должен быть в формате +992XXXXXXXXX.")]
        public required string Phone { get; set; }
        /// <summary>
        /// Связь пользователя с его ролью
        /// </summary>
        public required int RoleId { get; set; }
    }
}
