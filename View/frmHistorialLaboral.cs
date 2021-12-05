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
    public partial class frmHistorialLaboral : Form
    {
        int IdUser, IdCandidato, Id;
        public frmHistorialLaboral(int idUser, int idCandidato)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
        }
        public frmHistorialLaboral(int idUser, int idCandidato, int id)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            Id = id;

        }

        private void frmHistorialLaboral_Load(object sender, EventArgs e)
        {
            dtInicioLab.Format = DateTimePickerFormat.Custom; 
            dtInicioLab.CustomFormat = "dd/MM/yyyy";
            dtFinalLab.Format = DateTimePickerFormat.Custom;
            dtFinalLab.CustomFormat = "dd/MM/yyyy";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtPuesto.Text == "" || txtEntidad.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CCandidato.Insertar_HistorialLab(txtPuesto.Text, txtEntidad.Text, dtInicioLab.Value, dtFinalLab.Value, IdCandidato);
                txtPuesto.Text = "";
                txtEntidad.Text = "";
                MessageBox.Show("Se agregó el historial laboral", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
