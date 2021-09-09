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
 
    public partial class FrmPersonal : Form
    {
       
        BE_Personal oPersonal;
        BLL_Personal oBLLPersonal;
        public FrmPersonal()
        {
            InitializeComponent();

            oBLLPersonal = new BLL_Personal();
          
        }
      
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            CargaCombo();
            MostrarGrilla(dtgPersonal, oBLLPersonal.ListarTodoTable());
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Test _negocioT = new Test();
           MessageBox.Show ( _negocioT.TestConection());
        }
        private void CargaCombo() 
        {
            cbxTipoEmpleado.Items.Add("Administrador");
            cbxTipoEmpleado.Items.Add("Mostrador");
            cbxTipoEmpleado.Items.Add("Fabrica");
            cbxTipoEmpleado.SelectedIndex = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            CreoTipoEmpleado();
            LLenarObjeto();
            oBLLPersonal.Guardar(oPersonal);
            LimpiarCampos();
            MostrarGrilla(dtgPersonal, oBLLPersonal.ListarTodoTable());
        }
        private void CreoTipoEmpleado() 
        {
            if (cbxTipoEmpleado.Text == "Mostrador")
            {
                oPersonal = new BE_PersonalMostrador();
            }
            else if (cbxTipoEmpleado.Text == "Fabrica")
            {
                oPersonal = new BE_PersonalFabrica();
            }
            else if (cbxTipoEmpleado.Text == "Administrador")
            {
                oPersonal = new BE_PersonalAdministrador();
            }
        }
        private void LLenarObjeto() 
        {
            if(tbxNroEmpleado.Text != "") 
            {
               oPersonal.Codigo = int.Parse(tbxNroEmpleado.Text);
            }
            oPersonal.Apellido = tbxApellido.Text;
            oPersonal.Nombre  = tbxNombre.Text;
            oPersonal.Documento = int.Parse(tbxDocumento.Text);
            oPersonal.Tipo_Personal = cbxTipoEmpleado.Text;

       
        }
        private void LimpiarCampos() 
        {
            tbxNroEmpleado.Text = "";
            tbxApellido.Text = "";
            tbxNombre.Text = "";
            tbxDocumento.Text = "";
            cbxTipoEmpleado.SelectedItem = null;
        
        
        }
        private void MostrarGrilla(DataGridView pGrid, object obj) 
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dtgPersonal.SelectedRows.Count > 0)
            {
                CreoTipoEmpleado();
                LLenarObjeto();

                if (oBLLPersonal.Guardar(oPersonal))
                {
                    MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                LimpiarCampos();
                MostrarGrilla(dtgPersonal, oBLLPersonal.ListarTodoTable());
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un personal a modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void dtgPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            DataRowView _Filaseleccion = dtgPersonal.SelectedRows[0].DataBoundItem as DataRowView;
            if (_Filaseleccion != null) 
            {
                tbxNroEmpleado.Text = _Filaseleccion.Row[0].ToString();
                tbxApellido.Text = _Filaseleccion.Row[1].ToString();
                tbxNombre.Text = _Filaseleccion.Row[2].ToString();
                tbxDocumento.Text = _Filaseleccion.Row[3].ToString();
                cbxTipoEmpleado.Text = _Filaseleccion.Row[4].ToString();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }
    }
}
