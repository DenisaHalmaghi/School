using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Note
    {
        public int id { get; set; }

        [ForeignKey("Student")]
        public int id_student { get; set; }
        public string disciplina { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public decimal nota1 { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public decimal nota2 { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public decimal media { get; set; }
    }
}
