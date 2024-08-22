using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class StudentObrok
    {
        [ForeignKey("Person")]
        public int Id { get; set; }
        public Person Person { get; set; }

        [ForeignKey("Obrok")]
        public int ObrokId { get; set; }
        public Obrok Obrok { get; set; }
    }
}
