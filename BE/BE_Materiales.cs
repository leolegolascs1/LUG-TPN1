using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BE_Materiales : IEntidad, IDetalleCompra
    {
        #region Atributos
        private int _codigo;
        private string _descripcion_material;
        private string _material;
        private int _cantidad;
        #endregion
        #region Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion_material { get => _descripcion_material; set => _descripcion_material = value; }
        public string Material { get => _material; set => _material = value; }
        public int Cantidad { get => _cantidad ; set => _cantidad = value; }
        #endregion
        #region Metodos
        public BE_Materiales() { }
        public BE_Materiales(int pCodigo) 
        {
            this.Codigo = pCodigo;  
        }

        #endregion
    }
}
