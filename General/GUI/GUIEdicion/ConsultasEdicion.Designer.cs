﻿namespace General.GUI.GUIEdicion
{
    partial class ConsultasEdicion
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
            this.components = new System.ComponentModel.Container();
            this.cbPoseeCita = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID_Consulta = new System.Windows.Forms.TextBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCAsociada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPConsulta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechayHora = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDignostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPacientesID = new System.Windows.Forms.Label();
            this.txtPacientesID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPoseeCita
            // 
            this.cbPoseeCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoseeCita.FormattingEnabled = true;
            this.cbPoseeCita.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbPoseeCita.Location = new System.Drawing.Point(212, 330);
            this.cbPoseeCita.Name = "cbPoseeCita";
            this.cbPoseeCita.Size = new System.Drawing.Size(121, 28);
            this.cbPoseeCita.TabIndex = 80;
            this.cbPoseeCita.SelectedIndexChanged += new System.EventHandler(this.cbPoseeCita_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "¿Posee cita? ";
            // 
            // txtID_Consulta
            // 
            this.txtID_Consulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID_Consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID_Consulta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Consulta.Location = new System.Drawing.Point(202, 72);
            this.txtID_Consulta.Name = "txtID_Consulta";
            this.txtID_Consulta.ReadOnly = true;
            this.txtID_Consulta.Size = new System.Drawing.Size(20, 22);
            this.txtID_Consulta.TabIndex = 78;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(212, 224);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(162, 20);
            this.txtTratamiento.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tratamiento:";
            // 
            // cbbCAsociada
            // 
            this.cbbCAsociada.FormattingEnabled = true;
            this.cbbCAsociada.Items.AddRange(new object[] {
            "0"});
            this.cbbCAsociada.Location = new System.Drawing.Point(213, 379);
            this.cbbCAsociada.Name = "cbbCAsociada";
            this.cbbCAsociada.Size = new System.Drawing.Size(121, 21);
            this.cbbCAsociada.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Cita asociada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 44);
            this.label10.TabIndex = 73;
            this.label10.Text = "Precio de la\r\nconsulta: ";
            // 
            // txtPConsulta
            // 
            this.txtPConsulta.Location = new System.Drawing.Point(213, 267);
            this.txtPConsulta.Name = "txtPConsulta";
            this.txtPConsulta.Size = new System.Drawing.Size(121, 20);
            this.txtPConsulta.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 44);
            this.label9.TabIndex = 71;
            this.label9.Text = "Fecha y hora \r\nde la consulta";
            // 
            // dtpFechayHora
            // 
            this.dtpFechayHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechayHora.Location = new System.Drawing.Point(202, 118);
            this.dtpFechayHora.Name = "dtpFechayHora";
            this.dtpFechayHora.Size = new System.Drawing.Size(200, 20);
            this.dtpFechayHora.TabIndex = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 39);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 490);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 39);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Registro Consulta";
            // 
            // txtDignostico
            // 
            this.txtDignostico.Location = new System.Drawing.Point(212, 179);
            this.txtDignostico.Name = "txtDignostico";
            this.txtDignostico.Size = new System.Drawing.Size(162, 20);
            this.txtDignostico.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Diagnostico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "ID_Consulta:";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // lblPacientesID
            // 
            this.lblPacientesID.AutoSize = true;
            this.lblPacientesID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientesID.Location = new System.Drawing.Point(70, 428);
            this.lblPacientesID.Name = "lblPacientesID";
            this.lblPacientesID.Size = new System.Drawing.Size(119, 22);
            this.lblPacientesID.TabIndex = 82;
            this.lblPacientesID.Text = "ID del Paciente :";
            // 
            // txtPacientesID
            // 
            this.txtPacientesID.Location = new System.Drawing.Point(212, 431);
            this.txtPacientesID.Name = "txtPacientesID";
            this.txtPacientesID.Size = new System.Drawing.Size(121, 20);
            this.txtPacientesID.TabIndex = 81;
            // 
            // ConsultasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 541);
            this.Controls.Add(this.lblPacientesID);
            this.Controls.Add(this.txtPacientesID);
            this.Controls.Add(this.cbPoseeCita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID_Consulta);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCAsociada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPConsulta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechayHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDignostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "ConsultasEdicion";
            this.Text = "ConsultasEdicion";
            this.Load += new System.EventHandler(this.ConsultasEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbPoseeCita;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtID_Consulta;
        public System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbbCAsociada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPConsulta;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtpFechayHora;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDignostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Label lblPacientesID;
        public System.Windows.Forms.TextBox txtPacientesID;
    }
}