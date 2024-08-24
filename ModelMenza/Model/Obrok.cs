using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMenza.Model
{
    public class Obrok
    {
        [Key]
        public int Obrok_Id { get; set; }
        public string Obrok_Name { get; set; }
        public int Price { get; set; }
        public ICollection<StudentObrok> StudentObroci { get; set; }
        public ICollection<Order> Orders {  get; set; }
    }
}
