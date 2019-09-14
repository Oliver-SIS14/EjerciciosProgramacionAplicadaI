namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class SobreCargaPoligono
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
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.ApotemaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.AreaButton = new System.Windows.Forms.Button();
            this.PerimetroButton = new System.Windows.Forms.Button();
            this.PerimetroTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(160, 9);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 0;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(160, 35);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorTextBox.TabIndex = 1;
            // 
            // ApotemaTextBox
            // 
            this.ApotemaTextBox.Location = new System.Drawing.Point(160, 61);
            this.ApotemaTextBox.Name = "ApotemaTextBox";
            this.ApotemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApotemaTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserte La cantidad de lados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserte el valor de cada lado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inserte el apotema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(160, 123);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(139, 20);
            this.AreaTextBox.TabIndex = 8;
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(16, 121);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(122, 23);
            this.AreaButton.TabIndex = 9;
            this.AreaButton.Text = "Calcular Area";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.AreaButton_Click);
            // 
            // PerimetroButton
            // 
            this.PerimetroButton.Location = new System.Drawing.Point(16, 150);
            this.PerimetroButton.Name = "PerimetroButton";
            this.PerimetroButton.Size = new System.Drawing.Size(122, 23);
            this.PerimetroButton.TabIndex = 10;
            this.PerimetroButton.Text = "Calcular Perimetro";
            this.PerimetroButton.UseVisualStyleBackColor = true;
            this.PerimetroButton.Click += new System.EventHandler(this.PerimetroButton_Click);
            // 
            // PerimetroTextBox
            // 
            this.PerimetroTextBox.Location = new System.Drawing.Point(160, 149);
            this.PerimetroTextBox.Name = "PerimetroTextBox";
            this.PerimetroTextBox.Size = new System.Drawing.Size(139, 20);
            this.PerimetroTextBox.TabIndex = 11;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // SobreCargaPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 230);
            this.Controls.Add(this.PerimetroTextBox);
            this.Controls.Add(this.PerimetroButton);
            this.Controls.Add(this.AreaButton);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApotemaTextBox);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.CantidadTextBox);
            this.Name = "SobreCargaPoligono";
            this.Text = "SobreCargaPoligono";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox ApotemaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Button PerimetroButton;
        private System.Windows.Forms.TextBox PerimetroTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}