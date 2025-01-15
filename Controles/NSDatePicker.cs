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
    public class NSDatePicker : DateTimePicker
    {
        //fields
        //-> appearance
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;


        //-> other values
        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendari;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;


        //-> properties
        public Color SkinColor
        {
            get {return skinColor;}
            set { skinColor = value; calendarIcon = skinColor.GetBrightness() >= 0.8f ? Properties.Resources.calendari : Properties.Resources.calendari; this.Invalidate(); }
        }
        public Color TextColor { get {return textColor;} set { textColor = value; this.Invalidate(); } }
        public Color BorderColor { get {return borderColor; }set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get {return borderSize;} set { borderSize = value; this.Invalidate(); } }

        // -> constructor
        public NSDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5f);
            this.DropDownAlign = LeftRightAlignment.Right;

        }

        // -> overriden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(BorderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF IconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                // draw surface

                graphics.FillRectangle(skinBrush, clientArea);

                //draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);

                //draw ioen caklendar icon highlight
                if (droppedDown) graphics.FillRectangle(openIconBrush, IconArea);
                // draw border
                if (BorderSize >= 1)
                {
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }

                //draw icon
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.Cursor = iconButtonArea.Contains(e.Location) ? Cursors.Hand : Cursors.Default;
        }
        // private methods
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidth <= this.Width - (calendarIconWidth + 20))
            {
                return calendarIconWidth;
            }
            else { return arrowIconWidth; }
        }

    }
}
