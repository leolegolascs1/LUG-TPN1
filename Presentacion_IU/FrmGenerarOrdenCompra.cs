using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_BLL;
using BE;
namespace Presentacion_IU
{
    public partial class FrmGenerarOrdenCompra : Form
    {
        BLL_Personal oBLLPersonal;
        BLL_OrdenCompra oBLLOrdenCompra;
        BLL_Proveedor oBLLProveedor;
        BLL_Material oBLLMaterial;

        BE_OrdenCompra oBEOrdenCompra;
        BE_DetalleCompra oBEDetalleCompra;

        public FrmGenerarOrdenCompra()
        {
            InitializeComponent();
            oBLLOrdenCompra = new BLL_OrdenCompra();
            oBLLPersonal = new BLL_Personal();
            oBLLProveedor = new BLL_Proveedor();
            oBLLMaterial = new BLL_Material();

            oBEOrdenCompra = new BE_OrdenCompra();
            oBEDetalleCompra = new BE_DetalleCompra();
        }
        private void FrmGenerarOrdenCompra_Load(object sender, EventArgs e)
        {
            CargaCombo();
            MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodo());
        }
        private void CargaCombo()
        {
            cbxProveedor.DataSource = oBLLProveedor.ListarTodo();
            cbxProveedor.DisplayMember = "RazonSocial";
            cbxProveedor.ValueMember = "Codigo";
            cbxProveedor.SelectedItem = null;

            List<BE_Personal> _lstPersonal = new List<BE_Personal>();
            _lstPersonal = oBLLPersonal.ListarTodo();

            cbxPersonal.DataSource = _lstPersonal.FindAll(x => x.Tipo_Personal == "Fabrica");
            cbxPersonal.DisplayMember = "Nombre";
            cbxPersonal.ValueMember = "Codigo";
            cbxPersonal.SelectedItem = null;




            cbxItems.DataSource = oBLLMaterial.ListarTodo();
            cbxItems.DisplayMember = "Descripcion_Material";
            cbxItems.ValueMember = "Codigo";
            cbxItems.SelectedItem = null;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra;
            if (_Filaseleccion != null)
            {
                oBEDetalleCompra.NroItem = int.Parse(cbxItems.SelectedValue.ToString());
                oBEDetalleCompra.NroOrden = int.Parse(_Filaseleccion.Codigo.ToString());
                oBEDetalleCompra.Descripcion = cbxItems.Text;
                oBEDetalleCompra.Cantidad = int.Parse(tbxCantidad.Text);
            }
            oBLLOrdenCompra.Guardar(oBEDetalleCompra);
            LimpiarCampos();
            MostrarSeleccionOrden();
        }
        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            LLenarObjeto();
            oBLLOrdenCompra.Guardar(oBEOrdenCompra);
            LimpiarCampos();
            MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodoTable());
          
        }
        private void LLenarObjeto()
        {
            if (tbxNroOrden.Text != "")
            {
                oBEOrdenCompra.Codigo = int.Parse(tbxNroOrden.Text);
            }
            oBEOrdenCompra.Fecha = dtpFechaOrden.Value;

            List<BE_Proveedor> _lstProveedor = oBLLProveedor.ListarTodo();
            oBEOrdenCompra.Proveedor = _lstProveedor.Find(x => x.Codigo == int.Parse(cbxProveedor.SelectedValue.ToString()));

            List<BE_Personal> _lstPersonal = oBLLPersonal.ListarTodo();
            oBEOrdenCompra.Personal = _lstPersonal.Find(x => x.Codigo == int.Parse(cbxPersonal.SelectedValue.ToString()));
        }
        private void LimpiarCampos()
        {
            tbxNroOrden .Text = "";
            dtpFechaOrden.Value = DateTime.Today;
            cbxPersonal.SelectedItem = null;
            cbxProveedor .SelectedItem = null;
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
        }
        private void MostrarSeleccionOrden() 
        {
            LimpiarCampos();
            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra;
            if (_Filaseleccion != null)
            {
                tbxNroOrden.Text = _Filaseleccion.Codigo.ToString();
                List<BE_OrdenCompra> _lstOrdenCompra = new List<BE_OrdenCompra>();

                _lstOrdenCompra = oBLLOrdenCompra.ListarTodo();
                BE_OrdenCompra _aux = _lstOrdenCompra.Find(x => x.Codigo == _Filaseleccion.Codigo);
                MostrarGrilla(dtgDetalleItems, _aux.LstItems);
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DtgOrdenesCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarSeleccionOrden();
        }
    }
}
