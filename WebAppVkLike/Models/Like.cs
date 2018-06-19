using System;

namespace WebAppVkLike.Models
{
    public class Like
    {
        public int Id { get; set; }                 // первичный ключ
        public DateTime LkDateTime { get; set; }    // дата лайка
        public int ? PageId { get; set; }           // внешрий ключ

        public virtual Page Page { get; set; }      // навигационное свойство
    }
}