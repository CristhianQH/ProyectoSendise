namespace ProyectoSen
{
    partial class InicioUsuario
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
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCSesion = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Yellow;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.Location = new System.Drawing.Point(213, 279);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(175, 54);
            this.btnTareas.TabIndex = 2;
            this.btnTareas.Text = "TAREAS";
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrarC.FlatAppearance.BorderSize = 0;
            this.btnRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarC.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarC.Location = new System.Drawing.Point(213, 106);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarC.TabIndex = 4;
            this.btnRegistrarC.Text = "REGISTRAR CLIENTE";
            this.btnRegistrarC.UseVisualStyleBackColor = false;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrarE.FlatAppearance.BorderSize = 0;
            this.btnRegistrarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarE.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarE.Location = new System.Drawing.Point(213, 181);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarE.TabIndex = 5;
            this.btnRegistrarE.Text = "REGISTRAR EQUIPO";
            this.btnRegistrarE.UseVisualStyleBackColor = false;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 44);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCSesion);
            this.panel2.Controls.Add(this.btnRegistrarE);
            this.panel2.Controls.Add(this.btnTareas);
            this.panel2.Controls.Add(this.btnRegistrarC);
            this.panel2.Location = new System.Drawing.Point(246, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 428);
            this.panel2.TabIndex = 7;
            // 
            // btnCSesion
            // 
            this.btnCSesion.BackColor = System.Drawing.Color.Yellow;
            this.btnCSesion.FlatAppearance.BorderSize = 0;
            this.btnCSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSesion.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSesion.Location = new System.Drawing.Point(448, 16);
            this.btnCSesion.Name = "btnCSesion";
            this.btnCSesion.Size = new System.Drawing.Size(142, 34);
            this.btnCSesion.TabIndex = 6;
            this.btnCSesion.Text = "Cerrar Sesion";
            this.btnCSesion.UseVisualStyleBackColor = false;
            this.btnCSesion.Click += new System.EventHandler(this.btnCSesion_Click);
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InicioUsuario";
            this.Text = "InicioUsuario";
            this.Load += new System.EventHandler(this.InicioUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCSesion;
    }
}