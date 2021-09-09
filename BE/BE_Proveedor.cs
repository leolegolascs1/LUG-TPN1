﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BE_Proveedor:IEntidad
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private string _razonSocial;
        private string _cUIT;
        private string _cUIL;
        private string _eMail;
        private string _telefono;
        private string _localidad;
        private string _direccion;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string CUIT { get => _cUIT; set => _cUIT = value; }
        public string CUIL { get => _cUIL; set => _cUIL = value; }
        public string EMail { get => _eMail; set => _eMail = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
