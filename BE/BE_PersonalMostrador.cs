﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PersonalMostrador : BE_Personal
    {
        public BE_PersonalMostrador()
        {
            this.Tipo_Personal = "Empleado Mostrador";
        }
    }
}