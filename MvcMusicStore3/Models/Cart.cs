using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore3.Models
{
    public class Cart
    {
        // EF expects the primary key to the {class name}ID or ID, override it using the Key attribute
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Album Album { get; set; }
    }
}