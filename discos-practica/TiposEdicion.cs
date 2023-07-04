using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discos_practica
{
    internal class TiposEdicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set;}
        public override string ToString()
        {
            return Descripcion;
        }


    }
}
