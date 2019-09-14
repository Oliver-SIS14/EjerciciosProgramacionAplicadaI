namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class Factorial2
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.FactorialTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Factorial";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(96, 36);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(220, 20);
            this.NumeroTextBox.TabIndex = 2;
            // 
            // FactorialTextBox
            // 
            this.FactorialTextBox.Location = new System.Drawing.Point(96, 87);
            this.FactorialTextBox.Name = "FactorialTextBox";
            this.FactorialTextBox.Size = new System.Drawing.Size(220, 20);
            this.FactorialTextBox.TabIndex = 3;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(173, 150);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 4;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Factorial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 234);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.FactorialTextBox);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Factorial2";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox FactorialTextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}