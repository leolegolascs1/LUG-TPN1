using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;

namespace BE
{
    public abstract class BE_Personal:IEntidad
    {
        #region Atributos
        private int sueldBasico = 2000;
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private int _documento;
        private string _rol;
        private int _salario;
        private string _password;
        #endregion
        #region Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Documento { get => _documento; set => _documento = value; }
        public string Tipo_Personal { get => _rol; set => _rol = value; }
        public string Password { get => _password; set => _password = value; }
        public int Salario { get => _salario; set => _salario = value; }
        public int SueldBasico { get => sueldBasico; set => sueldBasico = value; }
        #endregion
        #region Metodos

        public override string ToString()
        {
            return this.Nombre + " - " + this.Apellido;
        }
        public BE_Personal() { }
        public BE_Personal(string pPass, int pNroPersonal)
        {
            this.Password = pPass;
            this.Codigo = pNroPersonal;
        }

        public abstract void CalcularSalario();

        #endregion

    }
}
