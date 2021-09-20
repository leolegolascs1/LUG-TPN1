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
        public List<BE_OrdenCompra> ListarTodo()
        {
            return oMPPOrdenCompra.ListarTodo();
        }
        public bool AgregarItemCompra(BE_OrdenCompra oBEOrdenCompra , BE_Materiales oBEMaterial, int pCantidad )
        {
            return oMPPOrdenCompra.AgregarItemCompra(oBEOrdenCompra,oBEMaterial,pCantidad);
        }
        public bool QuitarItemCompra(BE_OrdenCompra oBEOrdenCompra, BE_Materiales oBEMaterial)
        {
            return oMPPOrdenCompra.QuitarItemCompra(oBEOrdenCompra, oBEMaterial);
        }
        public bool EliminarOrden(BE_OrdenCompra oBEOrden)
        {
            return oMPPOrdenCompra.EliminarOrden(oBEOrden);
        }


    }
}
