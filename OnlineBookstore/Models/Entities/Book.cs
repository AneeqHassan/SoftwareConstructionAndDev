using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookstore.Models.Entities
{
    [Table("Books")]
    public class Book
    {
        [Column("book_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookId {  get; set; }
        [Column("book_name")]
        public string bookName { get; set; }
        [Column("book_genre")]
        public string bookGenre { get; set; }
        [Column("book_price")]
        public float bookPrice { get; set; }

    }
}
