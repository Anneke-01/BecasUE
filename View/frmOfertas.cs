using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Data;
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmOfertas : Form
    {
        public static int IDP, IDU, IDPP;
        public frmOfertas()
        {
            InitializeComponent();
        }

        private void frmOfertas_Load(object sender, EventArgs e)
        {
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtFinal.Format = DateTimePickerFormat.Custom;
            dtFinal.CustomFormat = "dd/MM/yyyy";
            txtTPro.Enabled = false;
            txtEspecialidad.Enabled = false;
            txtPaisP.Enabled = false;
            txtUniversidad.Enabled = false;
            txtCierre.Enabled = false;
            txtDiplomados.Enabled = false;
            txtCreditos.Enabled = false;
            txtDuracion.Enabled = false;
            txtDir.Enabled = false;
            txtCreacion.Enabled = false;
            txtApertura.Enabled = false;
            txtAprobado.Enabled = false;
            txtanio.Enabled = false;
            txtEstado.Enabled = false;
            txtPais.Enabled = false;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
            txtUniversidades.Enabled = false;
 

        }

        

        
        

        private void btnProm_Click(object sender, EventArgs e)
        {
            frmProgramas fp = new frmProgramas();
            fp.AccionDeshabilitar();
            fp.ShowDialog();
            
            if (fp.DialogResult == DialogResult.OK)
            {
                IDP = Convert.ToInt32(fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[0].Value.ToString());
                this.txtTPro.Text = fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtEspecialidad.Text = fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[2].Value.ToString();
                this.txtCreditos.Text = fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[3].Value.ToString();
                this.txtDiplomados.Text = fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[4].Value.ToString();
                this.txtDuracion.Text = fp.dtProgramas.Rows[fp.dtProgramas.CurrentRow.Index].Cells[5].Value.ToString();



            }
            
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            frmVerUniversidades fu = new frmVerUniversidades();
            fu.AccionDeshabilitar();
            fu.ShowDialog();
            
            if(fu.DialogResult == DialogResult.OK)
            {
                IDU = Convert.ToInt32(fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[0].Value.ToString());
                this.txtUniversidad.Text = fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtCiudad.Text = fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[2].Value.ToString();         
                this.txtTelefono.Text = fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[3].Value.ToString();
                this.txtPais.Text = fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[4].Value.ToString();
                this.txtDir.Text = fu.dtUniversidades.Rows[fu.dtUniversidades.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            frmPlanificacion frmp = new frmPlanificacion();
            frmp.AccionDeshabilitar();
            frmp.ShowDialog();

            if (frmp.DialogResult == DialogResult.OK)
            {
                IDPP = Convert.ToInt32(frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[0].Value.ToString());
                txtanio.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[1].Value.ToString();
                txtApertura.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[2].Value.ToString();
                txtCierre.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[3].Value.ToString();
                txtCreacion.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[4].Value.ToString();
                txtAprobado.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[5].Value.ToString();
                txtEstado.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[6].Value.ToString();
                txtPaisP.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[7].Value.ToString();
                txtUniversidades.Text = frmp.dtPlan.Rows[frmp.dtPlan.CurrentRow.Index].Cells[8].Value.ToString();
            }
                
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposPrograma())
            {
                MessageBox.Show("Debes de elegir un programa.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(VerificarCamposUniversidad()){
                MessageBox.Show("Debes de elegir una universidad.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (VerificarCamposPlanificación())
            {
                MessageBox.Show("Debes de elegir una planificación.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMonto.Text == "" || txtFinanciamiento.Text == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos de oferta.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                COferta.Insertar_Oferta(dtInicio.Value, dtFinal.Value, float.Parse(txtMonto.Text),float.Parse(txtFinanciamiento.Text), IDP, IDU, IDPP);
                MessageBox.Show("Se agregó una nueva oferta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public bool VerificarCamposPrograma()
        {
            if(txtTPro.Text == "" || txtEspecialidad.Text == "" || txtDiplomados.Text == "" || txtCreditos.Text == "" || txtDuracion.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarCamposUniversidad()
        {
            if(txtUniversidad.Text == "" || txtDir.Text == "" || txtPais.Text == "" || txtCiudad.Text == "" || txtTelefono.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarCamposPlanificación()
        {
            if(txtApertura.Text == "" || txtCreacion.Text == "" || txtAprobado.Text == "" || txtCierre.Text == "" || txtUniversidades.Text == "" || txtanio.Text == "" || txtPais.Text == "" || txtEstado.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
