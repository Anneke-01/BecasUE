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
    public partial class frmHistorialEstudiante : Form
    {
        int IdUser;
        public frmHistorialEstudiante(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;
        }

        private void frmHistorialEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
