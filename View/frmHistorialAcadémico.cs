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
    public partial class frmHistorialAcadémico : Form
    {
        int IdUser, IdCandidato, Id;
        bool EstadoEditar = false;
        string Titulo;
        DateTime FechaInicio, FechaFinal;
        public frmHistorialAcadémico(int idUser, int idCandidato)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            
            
        }
        public frmHistorialAcadémico(int idUser, int idCandidato,int id, string titulo, DateTime fechaInicio, DateTime fechaFinal)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            Id = id;
            Titulo = titulo;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            txtTitulo.Text = titulo;
            dtInicioAcademic.Value = fechaInicio;
            dtFinalAcademic.Value = fechaFinal;
            EstadoEditar = true;


        }
        public frmHistorialAcadémico(int idUser, int idCandidato, int id)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            Id = id;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(EstadoEditar == true)
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CCandidato.Editar_HistorialA(Id, txtTitulo.Text, dtInicioAcademic.Value, dtFinalAcademic.Value);
                    txtTitulo.Text = "";
                    MessageBox.Show("Se editó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CCandidato.Insertar_HistorialA(IdCandidato, txtTitulo.Text, dtInicioAcademic.Value, dtFinalAcademic.Value);
                    txtTitulo.Text = "";
                    MessageBox.Show("Se agregó el historial académico.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistorialEstudiante_Load(object sender, EventArgs e)
        {
            dtInicioAcademic.Format = DateTimePickerFormat.Custom;
            dtInicioAcademic.CustomFormat = "dd/MM/yyyy";
            dtFinalAcademic.Format = DateTimePickerFormat.Custom;
            dtFinalAcademic.CustomFormat = "dd/MM/yyyy";
        }
    }
}
