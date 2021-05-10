using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public int Id_producto { get; set; }
        public int Id_factura { get; set; }
        public DateTime Fecha { get; set; }

    }
}
