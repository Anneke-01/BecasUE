﻿namespace SistemaBecas.View
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubmenuOfertas = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOfertas = new System.Windows.Forms.Button();
            this.panelSubMenuProgramas = new System.Windows.Forms.Panel();
            this.btnverP = new System.Windows.Forms.Button();
            this.btnCrearP = new System.Windows.Forms.Button();
            this.btnPrograma = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelSubmenuOfertas.SuspendLayout();
            this.panelSubMenuProgramas.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panelSubmenuOfertas);
            this.panel1.Controls.Add(this.btnOfertas);
            this.panel1.Controls.Add(this.panelSubMenuProgramas);
            this.panel1.Controls.Add(this.btnPrograma);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 693);
            this.panel1.TabIndex = 0;
            // 
            // panelSubmenuOfertas
            // 
            this.panelSubmenuOfertas.Controls.Add(this.button2);
            this.panelSubmenuOfertas.Controls.Add(this.button1);
            this.panelSubmenuOfertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuOfertas.Location = new System.Drawing.Point(0, 392);
            this.panelSubmenuOfertas.Name = "panelSubmenuOfertas";
            this.panelSubmenuOfertas.Size = new System.Drawing.Size(256, 81);
            this.panelSubmenuOfertas.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Crear Ofertas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver ofertas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOfertas
            // 
            this.btnOfertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfertas.FlatAppearance.BorderSize = 0;
            this.btnOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertas.ForeColor = System.Drawing.Color.White;
            this.btnOfertas.Location = new System.Drawing.Point(0, 338);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(256, 54);
            this.btnOfertas.TabIndex = 4;
            this.btnOfertas.Text = "Ofertas";
            this.btnOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOfertas.UseVisualStyleBackColor = true;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // panelSubMenuProgramas
            // 
            this.panelSubMenuProgramas.Controls.Add(this.btnverP);
            this.panelSubMenuProgramas.Controls.Add(this.btnCrearP);
            this.panelSubMenuProgramas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProgramas.Location = new System.Drawing.Point(0, 256);
            this.panelSubMenuProgramas.Name = "panelSubMenuProgramas";
            this.panelSubMenuProgramas.Size = new System.Drawing.Size(256, 82);
            this.panelSubMenuProgramas.TabIndex = 3;
            // 
            // btnverP
            // 
            this.btnverP.BackColor = System.Drawing.Color.DarkBlue;
            this.btnverP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnverP.FlatAppearance.BorderSize = 0;
            this.btnverP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverP.ForeColor = System.Drawing.Color.White;
            this.btnverP.Location = new System.Drawing.Point(0, 0);
            this.btnverP.Name = "btnverP";
            this.btnverP.Size = new System.Drawing.Size(256, 38);
            this.btnverP.TabIndex = 0;
            this.btnverP.Text = "Ver programas";
            this.btnverP.UseVisualStyleBackColor = false;
            this.btnverP.Click += new System.EventHandler(this.btnverP_Click);
            // 
            // btnCrearP
            // 
            this.btnCrearP.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCrearP.FlatAppearance.BorderSize = 0;
            this.btnCrearP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearP.ForeColor = System.Drawing.Color.White;
            this.btnCrearP.Location = new System.Drawing.Point(0, 56);
            this.btnCrearP.Name = "btnCrearP";
            this.btnCrearP.Size = new System.Drawing.Size(256, 26);
            this.btnCrearP.TabIndex = 1;
            this.btnCrearP.Text = "Crear programa";
            this.btnCrearP.UseVisualStyleBackColor = false;
            this.btnCrearP.Click += new System.EventHandler(this.btnCrearP_Click);
            // 
            // btnPrograma
            // 
            this.btnPrograma.BackColor = System.Drawing.Color.Navy;
            this.btnPrograma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrograma.FlatAppearance.BorderSize = 0;
            this.btnPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograma.Location = new System.Drawing.Point(0, 202);
            this.btnPrograma.Name = "btnPrograma";
            this.btnPrograma.Size = new System.Drawing.Size(256, 54);
            this.btnPrograma.TabIndex = 2;
            this.btnPrograma.Text = "Programas";
            this.btnPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograma.UseVisualStyleBackColor = false;
            this.btnPrograma.Click += new System.EventHandler(this.btnCrearPrograma_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSalir);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 621);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 72);
            this.panel4.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(13, 26);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "____________________________________";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 202);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 36);
            this.panel2.TabIndex = 1;
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
            this.btnExit.Location = new System.Drawing.Point(607, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(543, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(58, 33);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.UseWaitCursor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(256, 36);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(666, 657);
            this.panelprincipal.TabIndex = 2;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprincipal_Paint);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 693);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.panel1.ResumeLayout(false);
            this.panelSubmenuOfertas.ResumeLayout(false);
            this.panelSubMenuProgramas.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrograma;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Panel panelSubMenuProgramas;
        private System.Windows.Forms.Button btnCrearP;
        private System.Windows.Forms.Button btnverP;
        private System.Windows.Forms.Panel panelSubmenuOfertas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}