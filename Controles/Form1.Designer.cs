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
            this.nsCircularPictureBox1 = new Controles.NSCircularPictureBox();
            this.nsDatePicker1 = new Controles.NSDatePicker();
            this.nsRadioButton1 = new Controles.NSRadioButton();
            this.nsTextBox1 = new Controles.NSTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nsCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nsCircularPictureBox1
            // 
            this.nsCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.nsCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nsCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.nsCircularPictureBox1.BorderLinestyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.nsCircularPictureBox1.BorderSize = 2;
            this.nsCircularPictureBox1.GradientAngle = 50F;
            this.nsCircularPictureBox1.Location = new System.Drawing.Point(490, 134);
            this.nsCircularPictureBox1.Name = "nsCircularPictureBox1";
            this.nsCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.nsCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nsCircularPictureBox1.TabIndex = 0;
            this.nsCircularPictureBox1.TabStop = false;
            // 
            // nsDatePicker1
            // 
            this.nsDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nsDatePicker1.BorderSize = 0;
            this.nsDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.nsDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.nsDatePicker1.Location = new System.Drawing.Point(335, 72);
            this.nsDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.nsDatePicker1.Name = "nsDatePicker1";
            this.nsDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.nsDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.nsDatePicker1.TabIndex = 1;
            this.nsDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // nsRadioButton1
            // 
            this.nsRadioButton1.AutoSize = true;
            this.nsRadioButton1.Location = new System.Drawing.Point(208, 134);
            this.nsRadioButton1.Name = "nsRadioButton1";
            this.nsRadioButton1.Size = new System.Drawing.Size(101, 17);
            this.nsRadioButton1.TabIndex = 2;
            this.nsRadioButton1.TabStop = true;
            this.nsRadioButton1.Text = "nsRadioButton1";
            this.nsRadioButton1.UseVisualStyleBackColor = true;
            // 
            // nsTextBox1
            // 
            this.nsTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.nsTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nsTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nsTextBox1.BorderSize = 2;
            this.nsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.nsTextBox1.Location = new System.Drawing.Point(468, 325);
            this.nsTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nsTextBox1.Multiline = false;
            this.nsTextBox1.Name = "nsTextBox1";
            this.nsTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.nsTextBox1.PasswordChar = false;
            this.nsTextBox1.Size = new System.Drawing.Size(250, 30);
            this.nsTextBox1.TabIndex = 3;
            this.nsTextBox1.UnderLinesStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsTextBox1);
            this.Controls.Add(this.nsRadioButton1);
            this.Controls.Add(this.nsDatePicker1);
            this.Controls.Add(this.nsCircularPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nsCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NSCircularPictureBox nsCircularPictureBox1;
        private NSDatePicker nsDatePicker1;
        private NSRadioButton nsRadioButton1;
        private NSTextBox nsTextBox1;
    }
}

