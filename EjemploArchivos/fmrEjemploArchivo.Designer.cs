namespace EjemploArchivos
{
    partial class fmrEjemploArchivo
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
            label1 = new Label();
            txtEntrada = new TextBox();
            txtSalida = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 0;
            label1.Text = "Introduzca el archivo o directorio:";
            // 
            // txtEntrada
            // 
            txtEntrada.BackColor = SystemColors.ActiveCaption;
            txtEntrada.Location = new Point(261, 15);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(476, 23);
            txtEntrada.TabIndex = 1;
            txtEntrada.KeyDown += txtEntrada_KeyDown;
            // 
            // txtSalida
            // 
            txtSalida.BackColor = SystemColors.ActiveCaption;
            txtSalida.Location = new Point(143, 61);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.Size = new Size(534, 357);
            txtSalida.TabIndex = 2;
            // 
            // fmrEjemploArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(807, 465);
            Controls.Add(txtSalida);
            Controls.Add(txtEntrada);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "fmrEjemploArchivo";
            Text = "Ejemplo de Archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEntrada;
        private TextBox txtSalida;
    }
}