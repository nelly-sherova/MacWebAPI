﻿namespace MacWebApi.Data.Models
{
    public class Role
    {
        /// <summary>
        /// Идетификатор
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
        /// Пользователи с этой ролью 
        /// </summary>
        public ICollection<User> Users { get; set; }

    }
}
