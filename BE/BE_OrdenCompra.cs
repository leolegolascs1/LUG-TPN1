using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BE_OrdenCompra:IEntidad 
    {
        #region Atributos
        private int _codigo;
        private DateTime _fecha;
        private int _nroPersonal;
        private int _nroProveedor;
        private List<BE_DetalleCompra> _lstItems;
        private BE_Personal _personal;
        private BE_Proveedor _proveedor;
        #endregion
        #region Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public BE_Personal Personal { get => _personal; set => _personal = value; } //RELACION 1 A 1
        public BE_Proveedor Proveedor { get => _proveedor; set => _proveedor = value; }//RELACION 1 A 1
        public List<BE_DetalleCompra> LstItems { get => _lstItems; set => _lstItems = value; }//RELACION 1 A MUCHOS
        public int NroPersonal { get => _nroPersonal; set => _nroPersonal = value; }
        public int NroProveedor { get => _nroProveedor; set => _nroProveedor = value; }
        #endregion
        public BE_OrdenCompra()
       {
           _lstItems = new List<BE_DetalleCompra>();
  
       }
   

    }

}
