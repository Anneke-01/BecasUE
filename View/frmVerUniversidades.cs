using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBecas.View
{
    public partial class frmVerUniversidades : Form
    {
        public frmVerUniversidades()
        {
            InitializeComponent();
            panelUniversidad.Visible = false;
            btnExit.Visible = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerUniversidades_Load(object sender, EventArgs e)
        {

        }
        public void AccionDeshabilitar()
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            panelUniversidad.Visible = true;
            btnExit.Visible = true;

        }
    }
}
