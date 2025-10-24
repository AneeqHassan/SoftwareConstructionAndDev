using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_and_LINQ.Models.Entities
{
    [Table("Courses")]
    public class Course
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title")]
        public string? Title { get; set; }

        [Column("credits")]
        public int Credits { get; set; }

        // Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
