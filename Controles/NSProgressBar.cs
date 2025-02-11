using System;
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
   
    public class NSProgressBar :ProgressBar
    {
        // fields
        private Color channelColor = Color.FromArgb(255, 108, 117, 125);
        private Color sliderColor = Color.FromArgb(255, 40, 167, 69);
        private Color foreBackColor = Color.PaleVioletRed;
        private int channelHeight = 6;
        private int sliderheight = 6;
        private MiTextPosition showValue = MiTextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;

        //others
        private bool paintedBack = false;
        private bool stopPainting = false;

        [Category("NSControls")]
        public Color ChannelColor
        {
            get
            {
                return channelColor;
            }

            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Category("NSControls")]
        public Color SliderColor
        {
            get
            {
                return sliderColor;
            }

            set
            {
                sliderColor = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]
        public Color ForeBackColor
        {
            get
            {
                return foreBackColor;
            }

            set
            {
                foreBackColor = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]
        public int ChannelHeight
        {
            get
            {
                return channelHeight;
            }

            set
            {
                channelHeight = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]
        public int Sliderheight
        {
            get
            {
                return sliderheight;
            }

            set
            {
                sliderheight = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]
        public MiTextPosition ShowValue
        {
            get
            {
                return showValue;
            }

            set
            {
                showValue = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }

        [Category("NSControls")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }


        [Category("NSControls")]

        public string SymbolBefore
        {
            get
            {
                return symbolBefore;
            }

            set
            {
                symbolBefore = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]

        public string SymbolAfter
        {
            get
            {
                return symbolAfter;
            }

            set
            {
                symbolAfter = value;
                this.Invalidate();

            }
        }
        [Category("NSControls")]

        public bool ShowMaximun
        {
            get
            {
                return showMaximun;
            }

            set
            {
                showMaximun = value;
                this.Invalidate();

            }
        }

        //constructor
        public NSProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }


        // -> paint the background & channel
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaint(e);
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //fields
                    Graphics graph = e.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, channelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= Sliderheight)
                        {
                            rectChannel.Y = this.Height - channelHeight;

                        }
                        else
                        {
                            rectChannel.Y = this.Height - ((channelHeight - sliderheight) / 2);
                        }

                        // painting
                        graph.Clear(this.Parent.BackColor); // surface
                        graph.FillRectangle(brushChannel, rectChannel); // Channel

                        // stop painting the back and channel
                        if (this.DesignMode == false)
                        {
                            paintedBack = true;
                        }


                    }

                    // reset painting the back channel
                    if (this.Value == this.Maximum || this.Value == this.Minimum)
                    {
                        paintedBack = false;
                    }
                }
            }
        }
        // -> paint slider
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            if (stopPainting == false)
            {
                Graphics graph = e.Graphics;
                double scaleFactor = ((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum);
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderheight);
                using(var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderheight >= channelHeight)
                    {
                        rectSlider.Y = this.Height - sliderheight;

                    }
                    else
                    {
                        rectSlider.Y = this.Height - ((sliderheight + channelHeight) / 2);
                    }

                    // painting
                    if (sliderWidth > 1)
                    {
                        graph.FillRectangle(brushSlider, rectSlider);
                    }
                    if (ShowValue != MiTextPosition.None)// text
                    {
                        DrawValueText(graph, sliderWidth, rectSlider);
                    }
                }

            }

            if (this.Value == this.Maximum)
            {
                stopPainting = true; // stop painting
            }
            else
            {
                stopPainting = false; // keep painting
            }
        }

        // -> paint value text
        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            // fields
            //string text = this.Value.ToString() + "%";

            string text = symbolBefore + this.Value.ToString() + symbolAfter;
            if (showMaximun)
            {
                text = text + "/" + symbolBefore + this.Maximum.ToString() + symbolAfter;
            }
            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);

            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTextBack = new SolidBrush(ForeBackColor))
                using(var textFormat = new StringFormat())
            {
                switch (showValue)
                {

                    case MiTextPosition.Left:

                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;

                    case MiTextPosition.Right:

                        rectText.X = this.Width -textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;

                    case MiTextPosition.Center:

                        rectText.X = (this.Width-textSize.Width)/2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;

                    case MiTextPosition.Sliding:

                        rectText.X = sliderWidth-textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        // clean previous text surface
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            Rectangle rect = rectSlider;
                            rectSlider.Y = rectText.Y;
                            rectText.Height = rectText.Height;
                            graph.FillRectangle(brushClear, rect);

                        }
                        break;
                    
                }
                //painting
                graph.FillRectangle(brushTextBack, rectText);
                graph.DrawString(text, this.Font, brushText, rectText, textFormat);
            }
        }

    }

    
}
