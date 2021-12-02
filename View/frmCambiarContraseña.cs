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
    public partial class frmCambiarContraseña : Form
    {
        int IdUser;
        public frmCambiarContraseña(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
