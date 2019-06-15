using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UsuarioAnalisis.Entidades
{
   public class TipoAnalisis
    {
        [Key]
        public int TipoAnalisisId { get; set; }

        public string Descripcion { get; set; }


        public TipoAnalisis()
        {
            TipoAnalisisId = 0;
            Descripcion = string.Empty;
        }
    }
}
