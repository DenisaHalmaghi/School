using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Student
    {
        public int id { get; set; }
        public List<Note> Note { get; set; }
        public string marca { get; set; }
        public string prenume { get; set; }
        public string nume { get; set; }
    }
}
