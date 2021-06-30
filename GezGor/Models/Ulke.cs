using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezGor.Models
{
    public class Ulke
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        public virtual ICollection<Sehir> Sehirler { get; set; }
    }
}
