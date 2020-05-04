namespace VeterinariaGUI
{
    partial class MenuServiciosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuServiciosFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.VeterinarioCmb = new System.Windows.Forms.Panel();
            this.BuscarServiciosBtn = new System.Windows.Forms.Button();
            this.MascotaBtn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarServicioBtn = new System.Windows.Forms.Button();
            this.VeterinarioDtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            this.VeterinarioCmb.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.MinimizarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 35);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Mascotas";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(1050, 5);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(25, 25);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.TabStop = false;
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(1021, 5);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 6;
            this.MinimizarBtn.TabStop = false;
            // 
            // VeterinarioCmb
            // 
            this.VeterinarioCmb.BackColor = System.Drawing.Color.DarkOrange;
            this.VeterinarioCmb.Controls.Add(this.BuscarServiciosBtn);
            this.VeterinarioCmb.Controls.Add(this.MascotaBtn);
            this.VeterinarioCmb.Controls.Add(this.label2);
            this.VeterinarioCmb.Location = new System.Drawing.Point(0, 38);
            this.VeterinarioCmb.Name = "VeterinarioCmb";
            this.VeterinarioCmb.Size = new System.Drawing.Size(1080, 64);
            this.VeterinarioCmb.TabIndex = 5;
            // 
            // BuscarServiciosBtn
            // 
            this.BuscarServiciosBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarServiciosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarServiciosBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarServiciosBtn.Image")));
            this.BuscarServiciosBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarServiciosBtn.Location = new System.Drawing.Point(991, 3);
            this.BuscarServiciosBtn.Name = "BuscarServiciosBtn";
            this.BuscarServiciosBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarServiciosBtn.TabIndex = 2;
            this.BuscarServiciosBtn.Text = "Buscar";
            this.BuscarServiciosBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarServiciosBtn.UseVisualStyleBackColor = false;
            // 
            // MascotaBtn
            // 
            this.MascotaBtn.FormattingEnabled = true;
            this.MascotaBtn.Items.AddRange(new object[] {
            "Cedula"});
            this.MascotaBtn.Location = new System.Drawing.Point(864, 23);
            this.MascotaBtn.Name = "MascotaBtn";
            this.MascotaBtn.Size = new System.Drawing.Size(121, 21);
            this.MascotaBtn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servicios Activos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(255, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 70);
            this.panel3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarServicioBtn
            // 
            this.AgregarServicioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarServicioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarServicioBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarServicioBtn.Image")));
            this.AgregarServicioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarServicioBtn.Location = new System.Drawing.Point(0, 157);
            this.AgregarServicioBtn.Name = "AgregarServicioBtn";
            this.AgregarServicioBtn.Size = new System.Drawing.Size(89, 70);
            this.AgregarServicioBtn.TabIndex = 16;
            this.AgregarServicioBtn.Text = "Agregar Servicio";
            this.AgregarServicioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarServicioBtn.UseVisualStyleBackColor = false;
            // 
            // VeterinarioDtg
            // 
            this.VeterinarioDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VeterinarioDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeterinarioDtg.Location = new System.Drawing.Point(-1, 229);
            this.VeterinarioDtg.Name = "VeterinarioDtg";
            this.VeterinarioDtg.Size = new System.Drawing.Size(1080, 312);
            this.VeterinarioDtg.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(563, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 70);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripcion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(830, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 70);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(103, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 70);
            this.panel5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(295, 157);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 70);
            this.panel6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuServiciosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1080, 540);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AgregarServicioBtn);
            this.Controls.Add(this.VeterinarioDtg);
            this.Controls.Add(this.VeterinarioCmb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuServiciosFrm";
            this.Text = "MenuServiciosFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.VeterinarioCmb.ResumeLayout(false);
            this.VeterinarioCmb.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.Panel VeterinarioCmb;
        private System.Windows.Forms.Button BuscarServiciosBtn;
        private System.Windows.Forms.ComboBox MascotaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarServicioBtn;
        private System.Windows.Forms.DataGridView VeterinarioDtg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
    }
}