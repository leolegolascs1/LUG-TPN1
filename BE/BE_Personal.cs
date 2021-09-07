using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;

namespace BE
{
    public abstract class BE_Personal:IEntidad
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private int _documento;
        private string _tipo_Personal;


        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Documento { get => _documento; set => _documento = value; }
        public string Tipo_Personal { get => _tipo_Personal; set => _tipo_Personal = value; }

        //public BE_Personal() { }

    }
}
