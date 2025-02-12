namespace Controles
{
    partial class FormControls
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnNS = new Controles.NSButton();
            this.ProgressBarTop = new Controles.NSProgressBar();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnNS
            // 
            this.BtnNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnNS.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnNS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnNS.BorderRadius = 40;
            this.BtnNS.BorderSize = 0;
            this.BtnNS.FlatAppearance.BorderSize = 0;
            this.BtnNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnNS.Location = new System.Drawing.Point(455, 220);
            this.BtnNS.Name = "BtnNS";
            this.BtnNS.Size = new System.Drawing.Size(150, 49);
            this.BtnNS.TabIndex = 1;
            this.BtnNS.Text = "nsButton1";
            this.BtnNS.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnNS.UseVisualStyleBackColor = false;
            this.BtnNS.Click += new System.EventHandler(this.BtnNs_Click_1);
            // 
            // ProgressBarTop
            // 
            this.ProgressBarTop.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ProgressBarTop.ChannelHeight = 8;
            this.ProgressBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarTop.ForeBackColor = System.Drawing.Color.PaleVioletRed;
            this.ProgressBarTop.ForeColor = System.Drawing.Color.White;
            this.ProgressBarTop.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarTop.Name = "ProgressBarTop";
            this.ProgressBarTop.ShowMaximun = false;
            this.ProgressBarTop.ShowValue = Controles.MiTextPosition.None;
            this.ProgressBarTop.Size = new System.Drawing.Size(800, 8);
            this.ProgressBarTop.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ProgressBarTop.Sliderheight = 8;
            this.ProgressBarTop.SymbolAfter = "";
            this.ProgressBarTop.SymbolBefore = "";
            this.ProgressBarTop.TabIndex = 0;
            this.ProgressBarTop.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNS);
            this.Controls.Add(this.ProgressBarTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private NSProgressBar ProgressBarTop;
        private NSButton BtnNS;
    }
}

