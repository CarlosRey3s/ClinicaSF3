namespace General.GUI.GUIGestiones
{
    partial class CosultasGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosultasGestion));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Diganostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_PrecioConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_PoseeCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citas_ID_Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_FechaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultas.ColumnHeadersHeight = 30;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Consulta,
            this.Cons_Diganostico,
            this.Cons_Tratamiento,
            this.Cons_PrecioConsulta,
            this.Cons_PoseeCita,
            this.ID_Paciente,
            this.Citas_ID_Cita,
            this.Cons_FechaConsulta});
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.Location = new System.Drawing.Point(38, 56);
            this.dgvConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1060, 526);
            this.dgvConsultas.TabIndex = 19;
            // 
            // ID_Consulta
            // 
            this.ID_Consulta.DataPropertyName = "ID_Consulta";
            this.ID_Consulta.FillWeight = 76.14214F;
            this.ID_Consulta.HeaderText = "ID_Consulta";
            this.ID_Consulta.MinimumWidth = 3;
            this.ID_Consulta.Name = "ID_Consulta";
            this.ID_Consulta.ReadOnly = true;
            // 
            // Cons_Diganostico
            // 
            this.Cons_Diganostico.DataPropertyName = "Cons_Diganostico";
            this.Cons_Diganostico.FillWeight = 104.7716F;
            this.Cons_Diganostico.HeaderText = "Diagnostico";
            this.Cons_Diganostico.MinimumWidth = 6;
            this.Cons_Diganostico.Name = "Cons_Diganostico";
            this.Cons_Diganostico.ReadOnly = true;
            // 
            // Cons_Tratamiento
            // 
            this.Cons_Tratamiento.DataPropertyName = "Cons_Tratamiento";
            this.Cons_Tratamiento.FillWeight = 104.7716F;
            this.Cons_Tratamiento.HeaderText = "Tratamiento";
            this.Cons_Tratamiento.MinimumWidth = 6;
            this.Cons_Tratamiento.Name = "Cons_Tratamiento";
            this.Cons_Tratamiento.ReadOnly = true;
            // 
            // Cons_PrecioConsulta
            // 
            this.Cons_PrecioConsulta.DataPropertyName = "Cons_PrecioConsulta";
            this.Cons_PrecioConsulta.FillWeight = 104.7716F;
            this.Cons_PrecioConsulta.HeaderText = "Precio";
            this.Cons_PrecioConsulta.MinimumWidth = 6;
            this.Cons_PrecioConsulta.Name = "Cons_PrecioConsulta";
            this.Cons_PrecioConsulta.ReadOnly = true;
            // 
            // Cons_PoseeCita
            // 
            this.Cons_PoseeCita.DataPropertyName = "Cons_PoseeCita";
            this.Cons_PoseeCita.HeaderText = "¿PoseeCita?";
            this.Cons_PoseeCita.MinimumWidth = 6;
            this.Cons_PoseeCita.Name = "Cons_PoseeCita";
            this.Cons_PoseeCita.ReadOnly = true;
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.DataPropertyName = "ID_Paciente";
            this.ID_Paciente.HeaderText = "PacienteID";
            this.ID_Paciente.MinimumWidth = 6;
            this.ID_Paciente.Name = "ID_Paciente";
            this.ID_Paciente.ReadOnly = true;
            // 
            // Citas_ID_Cita
            // 
            this.Citas_ID_Cita.DataPropertyName = "Citas_ID_Cita";
            this.Citas_ID_Cita.FillWeight = 104.7716F;
            this.Citas_ID_Cita.HeaderText = "CitaID";
            this.Citas_ID_Cita.MinimumWidth = 3;
            this.Citas_ID_Cita.Name = "Citas_ID_Cita";
            this.Citas_ID_Cita.ReadOnly = true;
            // 
            // Cons_FechaConsulta
            // 
            this.Cons_FechaConsulta.DataPropertyName = "Cons_FechaConsulta";
            this.Cons_FechaConsulta.FillWeight = 104.7716F;
            this.Cons_FechaConsulta.HeaderText = "FechayHora";
            this.Cons_FechaConsulta.MinimumWidth = 6;
            this.Cons_FechaConsulta.Name = "Cons_FechaConsulta";
            this.Cons_FechaConsulta.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Insertar,
            this.Modificar,
            this.toolStripSeparator2,
            this.Eliminar,
            this.txtFiltrar,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(41, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1057, 48);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(82, 45);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(97, 45);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 45);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltrar.Size = new System.Drawing.Size(249, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 45);
            // 
            // CosultasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 581);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CosultasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosultasGestion";
            this.Load += new System.EventHandler(this.CosultasGestion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Diganostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_PrecioConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_PoseeCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citas_ID_Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_FechaConsulta;
    }
}