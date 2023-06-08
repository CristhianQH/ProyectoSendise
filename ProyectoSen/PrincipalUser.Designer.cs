namespace ProyectoSen
{
    partial class PrincipalUser
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
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTecnico = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarR = new System.Windows.Forms.TextBox();
            this.btnBuscarR = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "TECNICO",
            "CLIENTE"});
            this.cmbBuscar.Location = new System.Drawing.Point(11, 76);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 21);
            this.cmbBuscar.TabIndex = 23;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(194, 77);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(119, 20);
            this.txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(385, 59);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(142, 54);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTecnico
            // 
            this.btnTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTecnico.FlatAppearance.BorderSize = 0;
            this.btnTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnico.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnico.Location = new System.Drawing.Point(12, 191);
            this.btnTecnico.Name = "btnTecnico";
            this.btnTecnico.Size = new System.Drawing.Size(154, 56);
            this.btnTecnico.TabIndex = 26;
            this.btnTecnico.Text = "TECNICO";
            this.btnTecnico.UseVisualStyleBackColor = false;
            this.btnTecnico.Click += new System.EventHandler(this.btnTecnico_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEquipo.FlatAppearance.BorderSize = 0;
            this.btnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipo.Location = new System.Drawing.Point(194, 191);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(155, 56);
            this.btnEquipo.TabIndex = 27;
            this.btnEquipo.Text = "EQUIPO";
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(385, 191);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(130, 56);
            this.btnCliente.TabIndex = 28;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 264);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.Size = new System.Drawing.Size(503, 307);
            this.dgvPrincipal.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "DNI Tecnico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBuscarR
            // 
            this.txtBuscarR.Location = new System.Drawing.Point(724, 207);
            this.txtBuscarR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarR.Name = "txtBuscarR";
            this.txtBuscarR.Size = new System.Drawing.Size(76, 20);
            this.txtBuscarR.TabIndex = 31;
            // 
            // btnBuscarR
            // 
            this.btnBuscarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscarR.FlatAppearance.BorderSize = 0;
            this.btnBuscarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarR.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarR.Location = new System.Drawing.Point(849, 191);
            this.btnBuscarR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarR.Name = "btnBuscarR";
            this.btnBuscarR.Size = new System.Drawing.Size(174, 52);
            this.btnBuscarR.TabIndex = 32;
            this.btnBuscarR.Text = "BUSCAR REPORTE";
            this.btnBuscarR.UseVisualStyleBackColor = false;
            this.btnBuscarR.Click += new System.EventHandler(this.btnBuscarR_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(569, 264);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(466, 307);
            this.dgvReporte.TabIndex = 33;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(810, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(224, 67);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // PrincipalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1046, 604);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnBuscarR);
            this.Controls.Add(this.txtBuscarR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.btnTecnico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Name = "PrincipalUser";
            this.Text = "PrincipalUser";
            this.Load += new System.EventHandler(this.PrincipalUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTecnico;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarR;
        private System.Windows.Forms.Button btnBuscarR;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnVolver;
    }
}