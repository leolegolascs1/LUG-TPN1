using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Materiales
    {
        private int _numero;
        private string _articulo;
        private string _material;

        public int Numero { get => _numero; set => _numero = value; }
        public string Articulo { get => _articulo; set => _articulo = value; }
        public string Material { get => _material; set => _material = value; }
    }
}
