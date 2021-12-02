using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.View;


namespace SistemaBecas.View
{
    public partial class frmMessageBoxOk : Form
    {
        int variable, IdUser;
        public frmMessageBoxOk(int v, int idUser)
        {
            InitializeComponent();
            variable = v;
            IdUser = idUser;
        }
        

        public void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();

            if(variable == 0)
            {
                frmEstudiante fc = new frmEstudiante(IdUser);
                fc.Show();
                this.Hide();
            }
            else
            {
                frmAdmin ad = new frmAdmin(IdUser);
                ad.Show();
                this.Hide();
            }

        }
        
        
    }
}
