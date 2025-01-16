﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Controles
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class NSComboBox: UserControl
    {
        // Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.ForestGreen;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int bordersize = 1;

        // Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        // Events
        public event EventHandler OnSelectedIndexChanged; // default event

        // Constructor
        public NSComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            // Combo Box Drop Down List
            cmbList.BackColor = backColor;
            cmbList.Font = new Font(this.Font.Name, 10f);
            cmbList.ForeColor = listBackColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexchanged);// defalut event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);// refresh text

            // BtnIcon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click); // open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); // draw icon

            //lblText
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10f);
            lblText.Click += new EventHandler(Surface_Click); // Select Combo Box

            // user Control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(bordersize);
            base.BackColor = borderColor;
            this.ResumeLayout();

            AdjustComoBoxDimensions();

        }
        #region private Methods
        private void AdjustComoBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        #endregion

        #region Event Methods

        private void Surface_Click(object sender, EventArgs e)
        {
            // Select combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cmbList.DroppedDown = true; // Open dropdown list
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            // draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
                using(Pen pen = new Pen(iconColor,2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }

        }

        private void Icon_Click(object sender, EventArgs e)
        {
            // open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true; // Open dropdown list


        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // refresh text
            lblText.Text = cmbList.Text;
        }
        #endregion

        #region Default Event
        private void ComboBox_SelectedIndexchanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            // refresh text
            lblText.Text = cmbList.Text;
        }
        #endregion
    }
}
