using System.Collections.Generic;

namespace WebAppVkLike.Models
{
    public class Page
    {
        public Page()
        {
            Likes = new List<Like>();
        }
        public int Id { get; set; }         // первичный ключ
        public string Name { get; set; }     // название страницы

        public virtual ICollection<Like> Likes { get; set; } // навигационное свойство
    }
}