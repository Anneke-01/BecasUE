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
        int variable;
        public frmMessageBoxOk(int v)
        {
            InitializeComponent();
            variable = v;
        }
        

        public void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();

            if(variable == 0)
            {
                frmEstudiante fc = new frmEstudiante();
                fc.Show();
                this.Hide();
            }
            else
            {
                frmAdmin ad = new frmAdmin();
                ad.Show();
                this.Hide();
            }

        }
        
        
    }
}
