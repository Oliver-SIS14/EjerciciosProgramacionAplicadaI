namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    partial class EnumNeumaticos
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
            this.NeumaticoLabel = new System.Windows.Forms.Label();
            this.NeumaticoCombobox = new System.Windows.Forms.ComboBox();
            this.SeleccionarButtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeumaticoLabel
            // 
            this.NeumaticoLabel.AutoSize = true;
            this.NeumaticoLabel.Location = new System.Drawing.Point(66, 38);
            this.NeumaticoLabel.Name = "NeumaticoLabel";
            this.NeumaticoLabel.Size = new System.Drawing.Size(138, 13);
            this.NeumaticoLabel.TabIndex = 0;
            this.NeumaticoLabel.Text = "Busque el tipo deneumatico";
            // 
            // NeumaticoCombobox
            // 
            this.NeumaticoCombobox.FormattingEnabled = true;
            this.NeumaticoCombobox.Items.AddRange(new object[] {
            "Diagonal ",
            "Radial",
            "Verano",
            "Invierno",
            "All seasons",
            "Asimetricos",
            "Direccionales",
            "Tubuless",
            "Perfil bajo",
            "Recauchutados",
            "Runflat",
            "Verdes"});
            this.NeumaticoCombobox.Location = new System.Drawing.Point(220, 35);
            this.NeumaticoCombobox.Name = "NeumaticoCombobox";
            this.NeumaticoCombobox.Size = new System.Drawing.Size(121, 21);
            this.NeumaticoCombobox.TabIndex = 1;
            // 
            // SeleccionarButtn
            // 
            this.SeleccionarButtn.Location = new System.Drawing.Point(360, 33);
            this.SeleccionarButtn.Name = "SeleccionarButtn";
            this.SeleccionarButtn.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarButtn.TabIndex = 2;
            this.SeleccionarButtn.Text = "Seleccionar";
            this.SeleccionarButtn.UseVisualStyleBackColor = true;
            this.SeleccionarButtn.Click += new System.EventHandler(this.SeleccionarButtn_Click);
            // 
            // EnumNeumaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 245);
            this.Controls.Add(this.SeleccionarButtn);
            this.Controls.Add(this.NeumaticoCombobox);
            this.Controls.Add(this.NeumaticoLabel);
            this.Name = "EnumNeumaticos";
            this.Text = "EnumNeumaticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NeumaticoLabel;
        private System.Windows.Forms.ComboBox NeumaticoCombobox;
        private System.Windows.Forms.Button SeleccionarButtn;
    }
}