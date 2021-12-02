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
    public partial class frmHistorialAcadémico : Form
    {
        int IdUser, IdCandidato;
        public frmHistorialAcadémico(int idUser, int idCandidato)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHistorialEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
