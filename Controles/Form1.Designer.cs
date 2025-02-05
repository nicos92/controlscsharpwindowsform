namespace Controles
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nsTextBox1 = new Controles.NSTextBox();
            this.SuspendLayout();
            // 
            // nsTextBox1
            // 
            this.nsTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.nsTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nsTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nsTextBox1.BorderSize = 2;
            this.nsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.nsTextBox1.Location = new System.Drawing.Point(379, 107);
            this.nsTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nsTextBox1.Multiline = false;
            this.nsTextBox1.Name = "nsTextBox1";
            this.nsTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.nsTextBox1.PasswordChar = false;
            this.nsTextBox1.ReadOnly = true;
            this.nsTextBox1.Size = new System.Drawing.Size(250, 30);
            this.nsTextBox1.TabIndex = 0;
            this.nsTextBox1.UnderLinesStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NSTextBox nsTextBox1;
    }
}

