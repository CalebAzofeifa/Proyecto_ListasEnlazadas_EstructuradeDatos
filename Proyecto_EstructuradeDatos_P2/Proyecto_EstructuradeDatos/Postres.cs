using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuradeDatos
{
    internal class Postres
    {
        public string Nombre { get; set; }
        public LinkedList<string> Ingredientes { get; set; } = new LinkedList<string>();
        public static Postres[] postresarray { get; set; } = new Postres[5];
    }
}
