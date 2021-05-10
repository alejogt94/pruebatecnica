using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Cliente
    {
        [Key]
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }

    }
}
