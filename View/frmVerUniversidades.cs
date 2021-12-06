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
    public partial class frmVerUniversidades : Form
    {
        public frmVerUniversidades()
        {
            InitializeComponent();
            panelUniversidad.Visible = false;
            btnExit.Visible = false;
            btnSeleccionar.Visible = false;
            this.dtUniversidades.DataSource = CUniversidad.ListarUniversidad();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerUniversidades_Load(object sender, EventArgs e)
        {
            this.dtUniversidades.DataSource = CUniversidad.ListarUniversidad();
        }
        public void AccionDeshabilitar()
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            panelUniversidad.Visible = true;
            btnExit.Visible = true;
            btnSeleccionar.Visible = true;

        }
        public void Actualizar()
        {
            this.dtUniversidades.DataSource = CUniversidad.ListarUniversidad();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtUniversidades.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtUniversidades.DataSource = CUniversidad.Buscar_Universidad(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNUniversidad frU = new frmNUniversidad();
            frU.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
