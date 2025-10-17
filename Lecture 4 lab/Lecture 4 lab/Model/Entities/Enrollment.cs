using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_lab.Model.Entities
{
    [Table("Enrollments")]
    public class Enrollment
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("student_id")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Column("course_id")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column("grade")]
        public string Grade { get; set; }

    }
}
