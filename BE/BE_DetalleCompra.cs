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
        #region atributos
        private int _codigo;
        private int _nroOrden;
        private int _nroItem;
        private string _descripcion;
        private int _cantidad;
        #endregion
        #region Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int NroOrden { get => _nroOrden; set => _nroOrden = value; }
        public int NroItem { get => _nroItem; set => _nroItem = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        #endregion

    }
}
