using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Login
    {
        #region Atributos
        private string _usuario;
        private string _contrasenia;
        #endregion
        #region Propiedades
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        #endregion
    }
}
