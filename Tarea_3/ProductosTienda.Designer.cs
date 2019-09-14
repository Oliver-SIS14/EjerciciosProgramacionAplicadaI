namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class ProductosTienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.DataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(66, 36);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(310, 20);
            this.CodigoTextBox.TabIndex = 6;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(66, 114);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(310, 20);
            this.PrecioTextBox.TabIndex = 7;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Location = new System.Drawing.Point(66, 88);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(310, 20);
            this.MarcaTextBox.TabIndex = 8;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(66, 62);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(310, 20);
            this.NombreTextBox.TabIndex = 9;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(394, 36);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(101, 23);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // DataGridViewProductos
            // 
            this.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Marca,
            this.Column3});
            this.DataGridViewProductos.Location = new System.Drawing.Point(16, 163);
            this.DataGridViewProductos.Name = "DataGridViewProductos";
            this.DataGridViewProductos.Size = new System.Drawing.Size(479, 150);
            this.DataGridViewProductos.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // ProductosTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 335);
            this.Controls.Add(this.DataGridViewProductos);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ProductosTienda";
            this.Text = "ProductosTienda";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridView DataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}