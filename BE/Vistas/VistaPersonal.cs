using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Vistas
{
    public class VistaPersonal
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public int Salario { get; set; }
        public string Rol { get; set; }

        public List<VistaPersonal> CargarGridVista(List<BE_Personal> pLista) //Recorro la lista de beneficiarios y voy generando la lista a mostrar en la grilla
        {
            List<VistaPersonal> _lstVistaFin = new List<VistaPersonal>();

            //Creo una lista que se enviará a la grilla
            foreach (BE_Personal  item in pLista) //Recorro la lista original y popula lista nueva
            {
                VistaPersonal  vistaN = new VistaPersonal();

                vistaN.Codigo = item.Codigo;
                vistaN.Nombre  = item.Nombre ;
                vistaN.Apellido  = item.Apellido;
                vistaN.Documento = item.Documento.ToString();
                vistaN.Salario = item.Salario;
                vistaN.Rol  = item.Tipo_Personal;

                _lstVistaFin.Add(vistaN);
            }
            return _lstVistaFin;
        }

    }
}
