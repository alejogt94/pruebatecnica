using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

    }
}
