using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture5Lab.Models.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("department")]
        public string Department { get; set; }
        [Column("salary")]
        public decimal Salary { get; set; }
        [Column("experience")]
        public int YearsExperience { get; set; }
    }
}
