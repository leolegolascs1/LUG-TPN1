using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public static class CL_Validar
    {
        static public bool EsNumerico(object num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
