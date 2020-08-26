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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblTrancisiones = new System.Windows.Forms.DataGridView();
            this.Tabla = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tblValor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPrifil = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tblAlfabeto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tblTokenReconocidos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLexico = new System.Windows.Forms.RichTextBox();
            this.tblMovimientos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrancisiones)).BeginInit();
            this.Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrifil)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTokenReconocidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Tabla);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 612);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblTrancisiones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz Transición";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblTrancisiones
            // 
            this.tblTrancisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTrancisiones.Location = new System.Drawing.Point(6, 6);
            this.tblTrancisiones.Name = "tblTrancisiones";
            this.tblTrancisiones.Size = new System.Drawing.Size(992, 574);
            this.tblTrancisiones.TabIndex = 5;
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
            this.Tabla.Size = new System.Drawing.Size(1004, 586);
            this.Tabla.TabIndex = 1;
            this.Tabla.Text = "Tabla Compacta";
            this.Tabla.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // tblValor
            // 
            this.tblValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblValor.Location = new System.Drawing.Point(32, 44);
            this.tblValor.Name = "tblValor";
            this.tblValor.Size = new System.Drawing.Size(440, 536);
            this.tblValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prifil";
            // 
            // tblPrifil
            // 
            this.tblPrifil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPrifil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrifil.Location = new System.Drawing.Point(541, 44);
            this.tblPrifil.Name = "tblPrifil";
            this.tblPrifil.Size = new System.Drawing.Size(404, 536);
            this.tblPrifil.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tblAlfabeto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1004, 586);
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
            this.tblAlfabeto.Size = new System.Drawing.Size(995, 576);
            this.tblAlfabeto.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tblTokenReconocidos);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txtLexico);
            this.tabPage4.Controls.Add(this.tblMovimientos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1004, 586);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimientos y Tokens Reconocidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tblTokenReconocidos
            // 
            this.tblTokenReconocidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTokenReconocidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTokenReconocidos.Location = new System.Drawing.Point(6, 372);
            this.tblTokenReconocidos.Name = "tblTokenReconocidos";
            this.tblTokenReconocidos.Size = new System.Drawing.Size(594, 208);
            this.tblTokenReconocidos.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(594, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Leer Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLexico
            // 
            this.txtLexico.Location = new System.Drawing.Point(6, 56);
            this.txtLexico.Name = "txtLexico";
            this.txtLexico.Size = new System.Drawing.Size(594, 296);
            this.txtLexico.TabIndex = 7;
            this.txtLexico.Text = "";
            // 
            // tblMovimientos
            // 
            this.tblMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tblMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMovimientos.Location = new System.Drawing.Point(606, 6);
            this.tblMovimientos.Name = "tblMovimientos";
            this.tblMovimientos.Size = new System.Drawing.Size(392, 574);
            this.tblMovimientos.TabIndex = 6;
            // 
            // winLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "winLexico";
            this.Size = new System.Drawing.Size(1012, 612);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTrancisiones)).EndInit();
            this.Tabla.ResumeLayout(false);
            this.Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrifil)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTokenReconocidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tblTrancisiones;
        private System.Windows.Forms.TabPage Tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblPrifil;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView tblAlfabeto;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView tblTokenReconocidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtLexico;
        private System.Windows.Forms.DataGridView tblMovimientos;
    }
}
