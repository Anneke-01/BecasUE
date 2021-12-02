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
    public partial class frmVisualizarCandidatos : Form
    {
        public frmVisualizarCandidatos()
        {
            InitializeComponent();
        }

        private void dtVerCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVisualizarCandidatos_Load(object sender, EventArgs e)
        {
            this.dtVerCandidatos.DataSource = CCandidato.Mostrar_Candidatos();
        }
    }
}
