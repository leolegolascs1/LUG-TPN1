using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Vistas
{
    public class VistaItemOrden
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }

        public List<VistaItemOrden> CargarGridVista(List<BE_Materiales> pLista) //Recorro la lista de beneficiarios y voy generando la lista a mostrar en la grilla
        {
            List<VistaItemOrden> _lstVistaFin = new List<VistaItemOrden>();

            //Creo una lista que se enviará a la grilla
            foreach (BE_Materiales item in pLista) //Recorro la lista original y popula lista nueva
            {
                VistaItemOrden vistaN = new VistaItemOrden();

                vistaN.Codigo = item.Codigo;
                vistaN.Descripcion = item.Descripcion_material;
                vistaN.Cantidad = item.Cantidad.ToString();

                _lstVistaFin.Add(vistaN);
            }
            return _lstVistaFin;
        }

    }
}
