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
    public class BLL_Personal
    {
        MPP_Personal oMPPPersonal;
        public BLL_Personal()
        {
            oMPPPersonal = new MPP_Personal();
        }
        public bool Guardar(BE_Personal oBEPersonal)
        {
            return oMPPPersonal.Guardar(oBEPersonal);
        }
        public DataTable ListarTodoTable()
        {
            return oMPPPersonal.ListarTodoTable();
        }
        public List<BE_Personal> ListarTodo()
        {
            return oMPPPersonal.ListarTodo();
        }
    }
}
