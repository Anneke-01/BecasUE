using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmProgramas : Form
    {
        public frmProgramas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNPrograma np = new frmNPrograma();
            np.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProgramas_Load(object sender, EventArgs e)
        {
            this.dtProgramas.DataSource = CPrograma.Leer_Programa();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.dtProgramas.SelectedRows.Count == 1)
            {
                
            }
        }
    }
}
