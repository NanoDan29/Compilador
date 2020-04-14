namespace ProyectoCompiladores
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.Sidebar);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 858);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.AutoSize = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.Sidebar.Controls.Add(this.button1);
            this.Sidebar.Controls.Add(this.panel6);
            this.Sidebar.Location = new System.Drawing.Point(9, 10);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(208, 834);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 81);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOS ROMPE TECLAS";
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(233, 12);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(870, 537);
            this.contenedor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 577);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel contenedor;
    }
}

