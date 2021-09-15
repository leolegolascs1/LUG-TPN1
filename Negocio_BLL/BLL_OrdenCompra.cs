using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MPP;
using BE;
namespace Negocio_BLL
{
    public class BLL_OrdenCompra
    {

        MPP_OrdenCompra oMPPOrdenCompra;
        public BLL_OrdenCompra()
        {
            oMPPOrdenCompra = new MPP_OrdenCompra();
        }
        public bool Guardar(BE_OrdenCompra oBEOrdenCompra)
        {
            return oMPPOrdenCompra.Guardar(oBEOrdenCompra);
        }
        public DataTable ListarTodoTable()
        {
            return oMPPOrdenCompra.ListarTodoTable();
        }
        public List<BE_Proveedor> ListarTodoProveedor()
        {
            return oMPPOrdenCompra.ListarTodoProveedor();
        }
        public List<BE_Personal> ListarTodoPersonal()
        {
            return oMPPOrdenCompra.ListarTodoPersonal();
        }
        public List<BE_Materiales> ListarTodoMaterial()
        {
            return oMPPOrdenCompra.ListarTodoMaterial();
        }
        public List<BE_OrdenCompra> ListarTodoOrdenCompra()
        {
            return oMPPOrdenCompra.ListarTodoOrdenCompra();
        }
        public bool Guardar(BE_DetalleCompra oBEDetalleCompra)
        {
            return oMPPOrdenCompra.Guardar(oBEDetalleCompra);
        }

    }
}
