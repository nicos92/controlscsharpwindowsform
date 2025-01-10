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
            this.nsDatePicker1 = new Controles.NSDatePicker();
            this.SuspendLayout();
            // 
            // nsDatePicker1
            // 
            this.nsDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nsDatePicker1.BorderSize = 0;
            this.nsDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.nsDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.nsDatePicker1.Location = new System.Drawing.Point(326, 153);
            this.nsDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.nsDatePicker1.Name = "nsDatePicker1";
            this.nsDatePicker1.Size = new System.Drawing.Size(296, 35);
            this.nsDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.nsDatePicker1.TabIndex = 0;
            this.nsDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsDatePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NSDatePicker nsDatePicker1;
    }
}

