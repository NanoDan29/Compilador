namespace ProyectoCompiladores.Léxico.Views
{
    partial class winLexico
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblTrancisiones = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tabla = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tblValor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPrifil = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tblAlfabeto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtLexico = new System.Windows.Forms.RichTextBox();
            this.tblMovimientos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrancisiones)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrifil)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTrancisiones
            // 
            this.tblTrancisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTrancisiones.Location = new System.Drawing.Point(6, 56);
            this.tblTrancisiones.Name = "tblTrancisiones";
            this.tblTrancisiones.Size = new System.Drawing.Size(732, 425);
            this.tblTrancisiones.TabIndex = 5;
            this.tblTrancisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblTrancisiones_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Tabla);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 574);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblTrancisiones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz Transición";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            this.Tabla.Controls.Add(this.label2);
            this.Tabla.Controls.Add(this.tblValor);
            this.Tabla.Controls.Add(this.label1);
            this.Tabla.Controls.Add(this.tblPrifil);
            this.Tabla.Location = new System.Drawing.Point(4, 22);
            this.Tabla.Name = "Tabla";
            this.Tabla.Padding = new System.Windows.Forms.Padding(3);
            this.Tabla.Size = new System.Drawing.Size(907, 548);
            this.Tabla.TabIndex = 1;
            this.Tabla.Text = "Tabla Compacta";
            this.Tabla.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // tblValor
            // 
            this.tblValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblValor.Location = new System.Drawing.Point(6, 71);
            this.tblValor.Name = "tblValor";
            this.tblValor.Size = new System.Drawing.Size(440, 440);
            this.tblValor.TabIndex = 2;
            this.tblValor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prifil";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tblPrifil
            // 
            this.tblPrifil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrifil.Location = new System.Drawing.Point(468, 71);
            this.tblPrifil.Name = "tblPrifil";
            this.tblPrifil.Size = new System.Drawing.Size(355, 440);
            this.tblPrifil.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tblAlfabeto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(907, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alfabeto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tblAlfabeto
            // 
            this.tblAlfabeto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAlfabeto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblAlfabeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlfabeto.Location = new System.Drawing.Point(4, 5);
            this.tblAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.tblAlfabeto.Name = "tblAlfabeto";
            this.tblAlfabeto.RowHeadersWidth = 51;
            this.tblAlfabeto.Size = new System.Drawing.Size(785, 495);
            this.tblAlfabeto.TabIndex = 0;
            this.tblAlfabeto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblAlfabeto_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txtLexico);
            this.tabPage4.Controls.Add(this.tblMovimientos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(907, 548);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtLexico
            // 
            this.txtLexico.Location = new System.Drawing.Point(6, 56);
            this.txtLexico.Name = "txtLexico";
            this.txtLexico.Size = new System.Drawing.Size(427, 446);
            this.txtLexico.TabIndex = 7;
            this.txtLexico.Text = "";
            // 
            // tblMovimientos
            // 
            this.tblMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tblMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMovimientos.Location = new System.Drawing.Point(444, 6);
            this.tblMovimientos.Name = "tblMovimientos";
            this.tblMovimientos.Size = new System.Drawing.Size(383, 496);
            this.tblMovimientos.TabIndex = 6;
            this.tblMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(907, 548);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(907, 548);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Leer Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // winLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "winLexico";
            this.Size = new System.Drawing.Size(915, 574);
            this.Load += new System.EventHandler(this.WinLexico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTrancisiones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Tabla.ResumeLayout(false);
            this.Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrifil)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTrancisiones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Tabla;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView tblPrifil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblValor;
        private System.Windows.Forms.DataGridView tblMovimientos;
        private System.Windows.Forms.DataGridView tblAlfabeto;
        private System.Windows.Forms.RichTextBox txtLexico;
        private System.Windows.Forms.Button button1;
    }
}
