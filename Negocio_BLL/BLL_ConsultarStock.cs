﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MPP;
using BE;
namespace Negocio_BLL
{

    public class BLL_ConsultarStock
    {
        MPP_Material oMPPMaterial = new MPP_Material();
        public DataTable ListarTodoTable()
        {
            return oMPPMaterial.ListarTodoTable();

        }
    }
}
