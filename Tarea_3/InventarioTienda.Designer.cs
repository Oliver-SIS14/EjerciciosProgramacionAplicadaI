namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class InventarioTienda
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
            this.InventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciasInicialesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalidasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.SalidasTextBox = new System.Windows.Forms.TextBox();
            this.EntradasTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciasTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InventarioDataGridView
            // 
            this.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoColumn,
            this.DescripcionColumn,
            this.ExistenciasInicialesColumn,
            this.EntradasColumn,
            this.SalidasColumn,
            this.StockColumn});
            this.InventarioDataGridView.Location = new System.Drawing.Point(12, 119);
            this.InventarioDataGridView.Name = "InventarioDataGridView";
            this.InventarioDataGridView.Size = new System.Drawing.Size(678, 221);
            this.InventarioDataGridView.TabIndex = 0;
   
            // 
            // CodigoColumn
            // 
            this.CodigoColumn.HeaderText = "Codigo Producto";
            this.CodigoColumn.Name = "CodigoColumn";
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripcion";
            this.DescripcionColumn.Name = "DescripcionColumn";
            // 
            // ExistenciasInicialesColumn
            // 
            this.ExistenciasInicialesColumn.HeaderText = "Existencias iniciales";
            this.ExistenciasInicialesColumn.Name = "ExistenciasInicialesColumn";
            // 
            // EntradasColumn
            // 
            this.EntradasColumn.HeaderText = "Entradas";
            this.EntradasColumn.Name = "EntradasColumn";
            // 
            // SalidasColumn
            // 
            this.SalidasColumn.HeaderText = "Salidas";
            this.SalidasColumn.Name = "SalidasColumn";
            // 
            // StockColumn
            // 
            this.StockColumn.HeaderText = "Stock";
            this.StockColumn.Name = "StockColumn";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(154, 39);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(161, 20);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(419, 65);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(144, 20);
            this.StockTextBox.TabIndex = 2;
            // 
            // SalidasTextBox
            // 
            this.SalidasTextBox.Location = new System.Drawing.Point(419, 39);
            this.SalidasTextBox.Name = "SalidasTextBox";
            this.SalidasTextBox.Size = new System.Drawing.Size(144, 20);
            this.SalidasTextBox.TabIndex = 3;
            // 
            // EntradasTextBox
            // 
            this.EntradasTextBox.Location = new System.Drawing.Point(419, 13);
            this.EntradasTextBox.Name = "EntradasTextBox";
            this.EntradasTextBox.Size = new System.Drawing.Size(144, 20);
            this.EntradasTextBox.TabIndex = 4;
            // 
            // ExistenciasTextBox
            // 
            this.ExistenciasTextBox.Location = new System.Drawing.Point(154, 65);
            this.ExistenciasTextBox.Name = "ExistenciasTextBox";
            this.ExistenciasTextBox.Size = new System.Drawing.Size(161, 20);
            this.ExistenciasTextBox.TabIndex = 5;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(154, 12);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(161, 20);
            this.CodigoTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entradas";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Existencias Iniciales";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(615, 16);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 43);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // InventarioTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 352);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.ExistenciasTextBox);
            this.Controls.Add(this.EntradasTextBox);
            this.Controls.Add(this.SalidasTextBox);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.InventarioDataGridView);
            this.Name = "InventarioTienda";
            this.Text = "InventarioTienda";
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciasInicialesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalidasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.TextBox SalidasTextBox;
        private System.Windows.Forms.TextBox EntradasTextBox;
        private System.Windows.Forms.TextBox ExistenciasTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarButton;
    }
}