using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Controles
{
        public class NSCircularPictureBox : PictureBox
        {
                //Fields
                private int borderSize = 2;
                private Color borderColor = Color.RoyalBlue;
                private Color borderColor2 = Color.HotPink;
                private DashStyle borderLinestyle = DashStyle.Solid;
                private DashCap borderCapStyle = DashCap.Flat;
                private float gradientAngle = 50f;

                //constructor
                public NSCircularPictureBox()
                {
                        this.Size = new Size(100, 100);
                        this.SizeMode = PictureBoxSizeMode.StretchImage;

                }

                public global::System.Int32 BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
                public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
                public Color BorderColor2 { get => borderColor2; set { borderColor2 = value; this.Invalidate(); } }
                public DashStyle BorderLinestyle { get => borderLinestyle; set { borderLinestyle = value; this.Invalidate(); } }
                public DashCap BorderCapStyle { get => borderCapStyle; set { borderCapStyle = value; this.Invalidate(); } }
                public global::System.Single GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

                // overridden methods
                protected override void OnResize(EventsArgs e)
                {
                        base.OnResize(e);
                        this.Size = new Size(this.Width, this.Width);
                }

                protected override void OnPaint(PaintEventArgs pe)
                {
                        base.OnPaint(pe);
                        //Fields
                        var graph = pe.Graphics;
                        var rectContoursmooth = Rectagle.Inflate(this.ClientRectangle, -1, -1);
                        var rectBorder = Rectangle.Inflate(rectContoursmooth, -borderSize, -borderSize);
                        var smoothSize = borderSize > 3 ? borderSize * 3 : 1;
                        using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
                        using (var pathRegion = new GraphicsPath())
                        using(var penSmooth = new Pen(this.ParentBackColor, smoothSize))
                        using(var penborder = new Pen(borderGColor, borderSize))
                        {
                                penborder.DashStyle = borderLinestyle;
                                penborder.DashCap = borderCapStyle;
                                pathRegion.AddEllipse(rectContoursmooth);
                                this.Region = new Region(pathRegion);
                                graph.SmoothingMode = SmoothingMode.AntiAlias;

                                // Drawing
                                graph.DrawEllipse(penSmooth, rectContoursmooth);
                                if (borderSize > 0)
                                {
                                        graph.DrawEllipse(penborder, rectBorder);
                                }
                        }
                

                }
        }
}