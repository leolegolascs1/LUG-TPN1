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
        MPP_Material oMPPMaterial;
        public BLL_OrdenCompra()
        {
            oMPPOrdenCompra = new MPP_OrdenCompra();
            oMPPMaterial = new MPP_Material();
        }
        public bool Guardar(BE_OrdenCompra oBEOrdenCompra)
        {
            return oMPPOrdenCompra.Guardar(oBEOrdenCompra);
        }
        public DataTable ListarTodoTable()
        {
            return oMPPOrdenCompra.ListarTodoTable();
        }
        public List<BE_OrdenCompra> ListarTodo()
        {
            return oMPPOrdenCompra.ListarTodo();
        }
        public bool Guardar(BE_DetalleCompra oBEDetalleCompra)
        {
            return oMPPOrdenCompra.Guardar(oBEDetalleCompra);
        }

    }
}
