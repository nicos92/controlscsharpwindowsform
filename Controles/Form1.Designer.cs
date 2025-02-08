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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nsProgressBar1 = new Controles.NSProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nsProgressBar1
            // 
            this.nsProgressBar1.ChannelColor = System.Drawing.Color.Red;
            this.nsProgressBar1.ChannelHeight = 6;
            this.nsProgressBar1.ForeBackColor = System.Drawing.Color.PaleVioletRed;
            this.nsProgressBar1.ForeColor = System.Drawing.Color.White;
            this.nsProgressBar1.Location = new System.Drawing.Point(37, 261);
            this.nsProgressBar1.Name = "nsProgressBar1";
            this.nsProgressBar1.ShowMaximun = false;
            this.nsProgressBar1.ShowValue = Controles.TextPosition.Right;
            this.nsProgressBar1.Size = new System.Drawing.Size(433, 23);
            this.nsProgressBar1.SliderColor = System.Drawing.Color.PaleGoldenrod;
            this.nsProgressBar1.Sliderheight = 6;
            this.nsProgressBar1.SymbolAfter = "";
            this.nsProgressBar1.SymbolBefore = "";
            this.nsProgressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsProgressBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private NSProgressBar nsProgressBar1;
    }
}

