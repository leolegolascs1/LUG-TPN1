﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace MPP
{
     public class TEST
    {
         Acceso   oAceeso = new Acceso();

        public string  TestConection() 
        {
            return oAceeso.TestConnection();
        }

    }
}