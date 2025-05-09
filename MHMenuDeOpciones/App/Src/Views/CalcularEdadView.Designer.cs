namespace MHMenuDeOpciones.App.Src.Views
{
    partial class CalcularEdadView
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
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendario.Location = new System.Drawing.Point(341, 44);
            this.calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(200, 26);
            this.calendario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su fecha de nacimiento";
            // 
            // btnCalcularEdad
            // 
            this.btnCalcularEdad.Location = new System.Drawing.Point(400, 129);
            this.btnCalcularEdad.Name = "btnCalcularEdad";
            this.btnCalcularEdad.Size = new System.Drawing.Size(140, 43);
            this.btnCalcularEdad.TabIndex = 3;
            this.btnCalcularEdad.Text = "Calcular edad";
            this.btnCalcularEdad.UseVisualStyleBackColor = true;
            this.btnCalcularEdad.Click += new System.EventHandler(this.btnCalcularEdad_Click);
            // 
            // CalcularEdadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 184);
            this.Controls.Add(this.btnCalcularEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcularEdadView";
            this.Text = "CalcularEdadView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularEdad;
    }
}