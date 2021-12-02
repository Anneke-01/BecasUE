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
    public partial class frmFormularioEstudianteVista : Form
    {
        int IdUser, IdCandidato;
        public frmFormularioEstudianteVista(int idUser, int idCandidato)
        {
            IdUser = idUser;
            IdCandidato = idCandidato;
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmHistorialAcadémico fm = new frmHistorialAcadémico(IdUser, IdCandidato);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmHistorialAcadémico fa = new frmHistorialAcadémico(IdUser,IdCandidato);
            fa.Show();
            this.Hide();
        }

        private void frmFormularioEstudianteVista_Load(object sender, EventArgs e)
        {
            
        }
    }
}
