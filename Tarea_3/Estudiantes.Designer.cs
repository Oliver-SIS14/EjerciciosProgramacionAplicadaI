namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class Estudiantes
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
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CarreraTextBox = new System.Windows.Forms.TextBox();
            this.MatriculaTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.Matricula,
            this.Carrera});
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(15, 123);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(342, 240);
            this.EstudiantesDataGridView.TabIndex = 0;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(74, 17);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(283, 20);
            this.NombreTextBox.TabIndex = 4;
            // 
            // CarreraTextBox
            // 
            this.CarreraTextBox.Location = new System.Drawing.Point(74, 83);
            this.CarreraTextBox.Name = "CarreraTextBox";
            this.CarreraTextBox.Size = new System.Drawing.Size(283, 20);
            this.CarreraTextBox.TabIndex = 5;
            // 
            // MatriculaTextBox
            // 
            this.MatriculaTextBox.Location = new System.Drawing.Point(74, 51);
            this.MatriculaTextBox.Name = "MatriculaTextBox";
            this.MatriculaTextBox.Size = new System.Drawing.Size(283, 20);
            this.MatriculaTextBox.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(141, 369);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 41);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 422);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MatriculaTextBox);
            this.Controls.Add(this.CarreraTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstudiantesDataGridView);
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CarreraTextBox;
        private System.Windows.Forms.TextBox MatriculaTextBox;
        private System.Windows.Forms.Button GuardarButton;
    }
}