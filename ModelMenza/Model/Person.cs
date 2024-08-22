using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string YearOfStudy { get; set; }
        public PersonDetail PersonDetail { get; set; }
        [ForeignKey("Fakultet")]
        public int Fakultet_Id { get; set; }
        public Fakultet Fakultet { get; set; }
        public ICollection<StudentObrok> StudentObroci { get; set; }

    }
}
