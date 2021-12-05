namespace SistemaBecas.View
{
    partial class frmEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOfertas = new System.Windows.Forms.Button();
            this.subMenuPerfil = new System.Windows.Forms.Panel();
            this.btnDatosGenerales = new System.Windows.Forms.Button();
            this.btnLaboral = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.subMenuPerfil.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnOfertas);
            this.panel1.Controls.Add(this.subMenuPerfil);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 631);
            this.panel1.TabIndex = 0;
            // 
            // btnOfertas
            // 
            this.btnOfertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfertas.FlatAppearance.BorderSize = 0;
            this.btnOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfertas.ForeColor = System.Drawing.Color.White;
            this.btnOfertas.Location = new System.Drawing.Point(0, 295);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(256, 42);
            this.btnOfertas.TabIndex = 5;
            this.btnOfertas.Text = "Ver Ofertas";
            this.btnOfertas.UseVisualStyleBackColor = true;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // subMenuPerfil
            // 
            this.subMenuPerfil.Controls.Add(this.btnDatosGenerales);
            this.subMenuPerfil.Controls.Add(this.btnLaboral);
            this.subMenuPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuPerfil.Location = new System.Drawing.Point(0, 201);
            this.subMenuPerfil.Name = "subMenuPerfil";
            this.subMenuPerfil.Size = new System.Drawing.Size(256, 94);
            this.subMenuPerfil.TabIndex = 4;
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.White;
            this.btnDatosGenerales.Image = ((System.Drawing.Image)(resources.GetObject("btnDatosGenerales.Image")));
            this.btnDatosGenerales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Size = new System.Drawing.Size(256, 43);
            this.btnDatosGenerales.TabIndex = 2;
            this.btnDatosGenerales.Text = "Cambiar Contraseña";
            this.btnDatosGenerales.UseVisualStyleBackColor = false;
            this.btnDatosGenerales.Click += new System.EventHandler(this.btnDatosGenerales_Click);
            // 
            // btnLaboral
            // 
            this.btnLaboral.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLaboral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLaboral.FlatAppearance.BorderSize = 0;
            this.btnLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaboral.ForeColor = System.Drawing.Color.White;
            this.btnLaboral.Image = ((System.Drawing.Image)(resources.GetObject("btnLaboral.Image")));
            this.btnLaboral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaboral.Location = new System.Drawing.Point(0, 51);
            this.btnLaboral.Name = "btnLaboral";
            this.btnLaboral.Size = new System.Drawing.Size(256, 43);
            this.btnLaboral.TabIndex = 1;
            this.btnLaboral.Text = "Historial Académico/Laboral";
            this.btnLaboral.UseVisualStyleBackColor = false;
            this.btnLaboral.Click += new System.EventHandler(this.btnLaboral_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(0, 159);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(256, 42);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 159);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 563);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 68);
            this.panel3.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(13, 22);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(16, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "_______________________________";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 36);
            this.panel2.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(256, 36);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(719, 595);
            this.panelPrincipal.TabIndex = 12;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(660, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(596, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(58, 33);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.UseWaitCursor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 631);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstudiante";
            this.panel1.ResumeLayout(false);
            this.subMenuPerfil.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel subMenuPerfil;
        private System.Windows.Forms.Button btnLaboral;
        private System.Windows.Forms.Button btnDatosGenerales;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimizar;
    }
}