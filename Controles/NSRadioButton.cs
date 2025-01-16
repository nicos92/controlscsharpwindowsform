using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Controles
{
    public class NSRadioButton : RadioButton
    {
        // fields
        private Color checkedColor = Color.MediumSlateBlue;
        private Color UncheckedColor = Color.DimGray;


        //properties
        public Color CheckedColor
        {
            get
            {
                return checkedColor;
            }

            set
            {
                checkedColor = value;
                this.Invalidate();
            }
        }

        public Color UncheckedColor1
        {
            get
            {
                return UncheckedColor;
            }

            set
            {
                UncheckedColor = value;
                this.Invalidate();
            }
        }
        // constructor

        public NSRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }

        //overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            //fields
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18f;
            float rbCheckSize = 12f;
            RectangleF rectRBBorder = new RectangleF()
            {
                X = 0.5f,
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            RectangleF rectRBCheck = new RectangleF()
            {
                X = rectRBBorder.X + ((rectRBBorder.Width - rbCheckSize) / 2), // center
                Y = (this.Height - rbCheckSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize
            };
            // Drawing
            using (Pen penBorder = new Pen(checkedColor, 1.6f))
            using (SolidBrush brushRBCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                // Draw surface
                g.Clear(this.BackColor);
                if (this.Checked)
                {
                    g.DrawEllipse(penBorder, rectRBBorder); //circle border
                    g.FillEllipse(brushRBCheck, rectRBCheck);
                }
                else
                {
                    penBorder.Color = UncheckedColor;
                    g.DrawEllipse(penBorder, rectRBBorder);
                }

                // draw text
                g.DrawString(this.Text, this.Font, brushText, rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2); // Y center




            }


        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text,this.Font).Width + 30;
        }

    }
}
