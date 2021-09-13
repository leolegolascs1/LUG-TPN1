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
   public class BLL_Material
   {
        MPP_Material oMPPMaterial;
        public BLL_Material()
        {
            oMPPMaterial = new MPP_Material();
        }
        public DataTable ListarTodoTable()
        {
            return oMPPMaterial.ListarTodoTable();
        }
        public bool Guardar(BE_Materiales oBEMaterial)
        {
            return oMPPMaterial.Guardar(oBEMaterial);
        }

    }
}
