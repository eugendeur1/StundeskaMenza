using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class PersonDetail
    {
        public int Detail_Id { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        [ForeignKey("Person")]
        public int Id { get; set; }
        public Person Person { get; set; }



    }
}
