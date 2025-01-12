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
            this.nsButton1 = new Controles.NSButton();
            this.SuspendLayout();
            // 
            // nsButton1
            // 
            this.nsButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nsButton1.BackGroudColor = System.Drawing.Color.MediumSlateBlue;
            this.nsButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nsButton1.BorderRadius = 17;
            this.nsButton1.BorderSize = 0;
            this.nsButton1.FlatAppearance.BorderSize = 0;
            this.nsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nsButton1.ForeColor = System.Drawing.Color.White;
            this.nsButton1.Location = new System.Drawing.Point(229, 96);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(249, 86);
            this.nsButton1.TabIndex = 0;
            this.nsButton1.Text = "nsButton1";
            this.nsButton1.TextColor = System.Drawing.Color.White;
            this.nsButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NSButton nsButton1;
    }
}

