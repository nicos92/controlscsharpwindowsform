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
            this.nsButton1 = new Controles.NSButton();
            this.nsProgressBar1 = new Controles.NSProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nsButton1
            // 
            this.nsButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.nsButton1.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.nsButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.nsButton1.BorderRadius = 40;
            this.nsButton1.BorderSize = 0;
            this.nsButton1.FlatAppearance.BorderSize = 0;
            this.nsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nsButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.nsButton1.Location = new System.Drawing.Point(455, 220);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(150, 49);
            this.nsButton1.TabIndex = 1;
            this.nsButton1.Text = "nsButton1";
            this.nsButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.nsButton1.UseVisualStyleBackColor = false;
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click_1);
            // 
            // nsProgressBar1
            // 
            this.nsProgressBar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.nsProgressBar1.ChannelHeight = 16;
            this.nsProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nsProgressBar1.ForeBackColor = System.Drawing.Color.PaleVioletRed;
            this.nsProgressBar1.ForeColor = System.Drawing.Color.White;
            this.nsProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.nsProgressBar1.Name = "nsProgressBar1";
            this.nsProgressBar1.ShowMaximun = false;
            this.nsProgressBar1.ShowValue = Controles.MiTextPosition.None;
            this.nsProgressBar1.Size = new System.Drawing.Size(800, 16);
            this.nsProgressBar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.nsProgressBar1.Sliderheight = 16;
            this.nsProgressBar1.SymbolAfter = "";
            this.nsProgressBar1.SymbolBefore = "";
            this.nsProgressBar1.TabIndex = 0;
            this.nsProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsButton1);
            this.Controls.Add(this.nsProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private NSProgressBar nsProgressBar1;
        private NSButton nsButton1;
    }
}

