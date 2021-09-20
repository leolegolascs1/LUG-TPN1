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
    public class BLL_Proveedor
    {
        MPP_Proveedor oMPP_Proveedor;
        public BLL_Proveedor()
        {
            oMPP_Proveedor = new MPP_Proveedor();
        }
        public bool Guardar(BE_Proveedor pOProveedor)
        {
           return oMPP_Proveedor.Guardar(pOProveedor);
        }
        public DataTable ListarTodoTable()
        {
            return oMPP_Proveedor.ListarTodoTable();
        }
        public List<BE_Proveedor> ListarTodo()
        {
            return oMPP_Proveedor.ListarTodo();
        }
        public bool Baja(BE_Proveedor pOProveedor)
        {
            return oMPP_Proveedor.Baja(pOProveedor);
        }
    }
}
