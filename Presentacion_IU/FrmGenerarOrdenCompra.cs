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
using BE.Vistas;
namespace Presentacion_IU
{
    public partial class FrmGenerarOrdenCompra : Form
    {
        BLL_Personal oBLLPersonal;
        BLL_OrdenCompra oBLLOrdenCompra;
        BLL_Proveedor oBLLProveedor;
        BLL_Material oBLLMaterial;

        BE_OrdenCompra oBEOrdenCompra;
        BE_Materiales oBEMaterial;
        VistaItemOrden oVistaOrden;

        public FrmGenerarOrdenCompra()
        {
            InitializeComponent();
            oBLLOrdenCompra = new BLL_OrdenCompra();
            oBLLPersonal = new BLL_Personal();
            oBLLProveedor = new BLL_Proveedor();
            oBLLMaterial = new BLL_Material();

            oBEOrdenCompra = new BE_OrdenCompra();

            oVistaOrden = new VistaItemOrden();
   
        }
        private void FrmGenerarOrdenCompra_Load(object sender, EventArgs e)
        {
            Deshabilitar_Controles();
            CargaCombo();
            MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodo());
            ContarFilas();
            if(dtgOrdenesCompra.Rows.Count > 0)
            {
                dtgOrdenesCompra.Rows[0].Selected = true;
                dtgOrdenesCompra.CurrentCell = dtgOrdenesCompra.Rows[0].Cells[0];
                MostrarSeleccionOrden();
            }
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
            try
            { 
                BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra;
                {
                    if(tbxCantidad.Text.Length > 0 || cbxItems.SelectedItem != null) //Valido si tiene cargado algo en cantidad y cbxitem
                    {
                        if (CL_Validar.EsNumerico(tbxCantidad.Text)) //Valido si el campo es numerico-
                        {
                            DialogResult dialogResult = MessageBox.Show("Se va a agregar un item a la Orden Nº"+tbxNroOrden.Text + ", está seguro?", "Agregar Item", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                oBEOrdenCompra = oBLLOrdenCompra.ListarTodo().Find(x => x.Codigo == int.Parse(_Filaseleccion.Codigo.ToString()));
                                oBEMaterial = oBLLMaterial.ListarTodo().Find(x => x.Codigo == int.Parse(cbxItems.SelectedValue.ToString())); //Traigo el item seleccionado
                             
                                if(oBEOrdenCompra.LstItems.Exists(x=>x.Codigo == oBEMaterial.Codigo) == false) //Si el item no esta repetido lo agrego
                                {
                                    oBLLOrdenCompra.AgregarItemCompra(oBEOrdenCompra, oBEMaterial, int.Parse(tbxCantidad.Text)); //Guardo el detalle-
                                }
                                else
                                {
                                    MessageBox.Show("El item ya se encuentra agregado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }                             
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor numerico en Cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la cantidad de items", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
               
                LimpiarCampos();
                MostrarSeleccionOrden();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                LLenarObjeto();
                oBLLOrdenCompra.Guardar(oBEOrdenCompra);
                LimpiarCampos();
                MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodo());
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            oBEOrdenCompra.NroProveedor = oBEOrdenCompra.Proveedor.Codigo;

            List<BE_Personal> _lstPersonal = oBLLPersonal.ListarTodo();
            oBEOrdenCompra.Personal = _lstPersonal.Find(x => x.Codigo == int.Parse(cbxPersonal.SelectedValue.ToString()));
            oBEOrdenCompra.NroPersonal  = oBEOrdenCompra.Personal.Codigo;

        }
        private void LimpiarCampos()
        {
            tbxNroOrden .Text = "";
            dtpFechaOrden.Value = DateTime.Today;
            cbxPersonal.SelectedItem = null;
            cbxProveedor .SelectedItem = null;
            cbxItems.SelectedItem = null;
            tbxCantidad.Text = "";
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;

            pGrid.AutoResizeColumns();
        }
        private void ContarFilas()
        {
            tbxCantidadItems.Text = dtgDetalleItems.Rows.Count.ToString();
            tbxCantidadOrdenes.Text = dtgOrdenesCompra.Rows.Count.ToString();
        }
        private void MostrarSeleccionOrden() 
        {
            LimpiarCampos();

            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra; // Creo onjeto orden

            if (_Filaseleccion != null) //Si esta seleccionada la celda
            {        
                List<BE_OrdenCompra> _lstOrdenCompra = new List<BE_OrdenCompra>(); //Creo lista                
                _lstOrdenCompra = oBLLOrdenCompra.ListarTodo(); //Cargo lista con todas las ordenes
                BE_OrdenCompra _aux = _lstOrdenCompra.Find(x => x.Codigo == _Filaseleccion.Codigo); //Filtro por la orden seleccionada.

                MostrarGrilla(dtgDetalleItems,oVistaOrden.CargarGridVista(_aux.LstItems)); //Muestro en la grilla de detalles la l
                ContarFilas();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void MostrarSeleccionModificar()
        {
            LimpiarCampos();

            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra; // Creo onjeto orden

            if (_Filaseleccion != null) //Si esta seleccionada la celda
            {
                List<BE_OrdenCompra> _lstOrdenCompra = new List<BE_OrdenCompra>(); //Creo lista                
                _lstOrdenCompra = oBLLOrdenCompra.ListarTodo(); //Cargo lista con todas las ordenes
                BE_OrdenCompra _aux = _lstOrdenCompra.Find(x => x.Codigo == _Filaseleccion.Codigo); //Filtro por la orden seleccionada.

                //Cargo los datos en los textbox.
                tbxNroOrden.Text = _aux.Codigo.ToString();
                cbxPersonal.SelectedValue = _aux.NroPersonal;
                cbxProveedor.SelectedValue = _aux.NroProveedor;
                dtpFechaOrden.Value = _aux.Fecha;
                MostrarGrilla(dtgDetalleItems,oVistaOrden.CargarGridVista(_aux.LstItems)); //Muestro en la grilla de detalles la l
                ContarFilas();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DtgOrdenesCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Deshabilitar_Controles();
            MostrarSeleccionOrden();
        }
        private void DtgOrdenesCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Habilitar_Controles();
            MostrarSeleccionModificar();
        }
        private void BtnNuevaOrden_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Habilitar_Controles();
            btnEliminar.Enabled = false;
        }
        private void Habilitar_Controles()
        {
            tbxCantidad.Enabled = true;
            dtpFechaOrden.Enabled = true;
            cbxPersonal.Enabled = true;
            cbxProveedor.Enabled = true;
            cbxItems.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGenerarOrden.Enabled = true;
            btnNuevaOrden.Enabled = false;
        }
        private void Deshabilitar_Controles()
        {
            tbxCantidad.Enabled = false;
            dtpFechaOrden.Enabled = false;
            cbxPersonal.Enabled = false;
            cbxProveedor.Enabled = false;
            cbxItems.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGenerarOrden.Enabled = false;
            btnNuevaOrden.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Deshabilitar_Controles();      
        }
        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            try
            {
                BE_OrdenCompra _Filaseleccionorden = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra; // Creo onjeto orden
                VistaItemOrden  _Filaseleccionitem = dtgDetalleItems.CurrentRow.DataBoundItem as VistaItemOrden; // Creo onjeto orden

                DialogResult dialogResult = MessageBox.Show("Se va a eliminar el ITEM Nº" + _Filaseleccionitem.Codigo  + ", está seguro?", "Eliminar Item", MessageBoxButtons.YesNo);
                if (_Filaseleccionorden != null || _Filaseleccionitem != null) //Si esta seleccionada la celda
                {
                    BE_Materiales oBEMaterialAux = new BE_Materiales();

                    oBEMaterialAux.Codigo = _Filaseleccionitem.Codigo;
                    if (dialogResult == DialogResult.Yes)
                    {
                        oBLLOrdenCompra.QuitarItemCompra(_Filaseleccionorden, oBEMaterialAux);
                        MostrarSeleccionOrden();
                        MessageBox.Show("Item Eliminado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione una Orden de Compra y un Item a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BE_OrdenCompra _Filaseleccionorden = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra; // Creo onjeto orden

                DialogResult dialogResult = MessageBox.Show("Desea ELIMINAR la ORDEN DE COMPRA Nº" + _Filaseleccionorden.Codigo + "?", "Eliminar Item", MessageBoxButtons.YesNo);
                if (_Filaseleccionorden != null) //Si esta seleccionada la celda
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        oBLLOrdenCompra.EliminarOrden(_Filaseleccionorden);
                        MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodo());
                        MostrarSeleccionOrden();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione una Orden de Compra a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
