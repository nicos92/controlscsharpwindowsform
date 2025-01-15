using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    [DefaultEvent("_TextChanged")]
    public partial class NSTextBox : UserControl
    {

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinesStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        public NSTextBox()
        {
            InitializeComponent();
        }

        // Events

        public event EventHandler _TextChanged;

        //properties
        [Category("NS Text Box")]
        public Color BorderColor
        {
            get { return borderColor; }


            set { borderColor = value; this.Invalidate(); }
        }
        [Category("NS Text Box")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }
        [Category("NS Text Box")]
        public bool UnderLinesStyle
        {
            get { return underLinesStyle; }
            set
            {
                underLinesStyle = value; this.Invalidate();
            }
        }

        // overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            //draw border
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isFocused)
                {
                    if (underLinesStyle)
                    {
                        g.DrawLine(pen, 0, this.Height - 1, this.Width - 0.5f, this.Height - 1);
                    }
                    else
                    {
                        g.DrawRectangle(pen, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }
                else
                {
                    pen.Color = borderFocusColor;
                    if (underLinesStyle)
                    {
                        g.DrawLine(pen, 0, this.Height - 1, this.Width - 0.5f, this.Height - 1);
                    }
                    else
                    {
                        g.DrawRectangle(pen, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }

            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); UpdateControlHeight();
        }

        [Category("NS Text Box")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("NS Text Box")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("NS Text Box")]
        public override Color BackColor { get { return base.BackColor; } set { base.BackColor = value; textBox1.BackColor = value; } }

        [Category("NS Text Box")]
        public override Color ForeColor { get { return base.ForeColor; } set { base.ForeColor = value; textBox1.ForeColor = value; } }

        [Category("NS Text Box")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("NS Text Box")]
        public override string Text { get {return textBox1.Text;} set { textBox1.Text = value; }}

        [Category("NS Text Box")]
        public Color BorderFocusColor { get {return borderFocusColor; }set { borderFocusColor = value;} }




        // private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
