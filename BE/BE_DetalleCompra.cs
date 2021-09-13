using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BE_DetalleCompra:IEntidad
    {
        private int _codigo;
        private string _descripcion;
        private int _cantidad;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
