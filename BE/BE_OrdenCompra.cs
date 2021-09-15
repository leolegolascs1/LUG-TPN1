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
        private int _codigo;
        private DateTime _fecha;
        private string _nombreProveedor;
        private string _nombrePersonal;
        private List<BE_DetalleCompra> _lstItems;
        private BE_Personal _personal;
        private BE_Proveedor _proveedor;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public BE_Personal Personal { get => _personal; set => _personal = value; }
        public BE_Proveedor Proveedor { get => _proveedor; set => _proveedor = value; }

        public List<BE_DetalleCompra> LstItems { get => _lstItems; set => _lstItems = value; }
        public string NombreProveedor { get => _nombreProveedor; set => _nombreProveedor = value; }
        public string NombrePersonal { get => _nombrePersonal; set => _nombrePersonal = value; }

        public BE_OrdenCompra()
       {
           _lstItems = new List<BE_DetalleCompra>();
    

       }
       public void GenerarNombres()
       {
            _nombreProveedor = Proveedor.RazonSocial;
            _nombrePersonal = Personal.Apellido + ", " + Personal.Nombre;
       }

    }

}
