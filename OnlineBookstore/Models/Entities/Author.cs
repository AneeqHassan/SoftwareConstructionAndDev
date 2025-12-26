using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookstore.Models.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Column("author_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int authorId { get; set; }
        [Column("author_name")]
        public string authorName { get; set; } 

        

    }
}
