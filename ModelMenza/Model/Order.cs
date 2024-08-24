using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }

        [ForeignKey("Person")]
        public int StudentId { get; set; }
        public Person Person { get; set; }

        public DateTime OrderDate { get; set; }

        public int ObrokId { get; set; } 
        [ForeignKey("ObrokId")]
        public Obrok Obrok { get; set; }
    }
}
