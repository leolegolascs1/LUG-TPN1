using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Negocio_BLL;

namespace Presentacion_IU
{
    public partial class FrmInformesGenerales : Form
    {
        BLL_Personal oBLLPersonal;
        BLL_OrdenCompra oBLLOrdenCompra;
        BLL_Proveedor oBLLProveedor;

        BLL_Material oBLLMaterial;
        BE_OrdenCompra oBEOrdenCompra;

        public FrmInformesGenerales()
        {
            InitializeComponent();
            oBLLOrdenCompra = new BLL_OrdenCompra();
            oBLLPersonal = new BLL_Personal();
            oBLLProveedor = new BLL_Proveedor();
            oBLLMaterial = new BLL_Material();

            oBEOrdenCompra = new BE_OrdenCompra();
    
        }

        private void FrmInformesGenerales_Load(object sender, EventArgs e)
        {
            RealizarInforme();
        }
        private void RealizarInforme() 
        {
            tbxPersonal.Text = oBLLPersonal.ListarTodo().Count.ToString();  
            tbxProveedores.Text = oBLLProveedor.ListarTodo().Count.ToString();
            int cont = 0;
            List<BE_OrdenCompra> _lstOrden = new List<BE_OrdenCompra>();
            _lstOrden = oBLLOrdenCompra.ListarTodo();

            tbxOrdenes.Text = _lstOrden.Count.ToString();

            foreach (BE_OrdenCompra orden in _lstOrden)
            {
                foreach (BE_Materiales detalle in orden.LstItems)
                {
                  //  cont += detalle.Cantidad;//
                }
            }




            tbxItemPedidos.Text = cont.ToString();

        }

    }
}
