using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class Fakultet
    {
        [Key]
        public int Fakultet_Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Person> Persons { get; set; }

    }
}
