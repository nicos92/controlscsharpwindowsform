using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public  class ColoresARGB
    {
        private readonly Color primary = Color.FromArgb(255, 0, 123, 255);
        private readonly Color secondary = Color.FromArgb(255, 108, 117, 125);
        private readonly Color success = Color.FromArgb(255, 40, 167, 69);
        private readonly Color info = Color.FromArgb(255, 23, 162, 184);
        private readonly Color warning = Color.FromArgb(255, 255, 193, 7);
        private readonly Color danger = Color.FromArgb(255, 220, 53, 69);
        private readonly Color light = Color.FromArgb(255, 248, 249, 250);
        private readonly Color dark = Color.FromArgb(255, 32, 37, 42);
        private readonly Color darkBackText = Color.FromArgb(255, 26, 31, 34);

        private readonly Color white = Color.FromArgb(255, 254, 254, 254);
        private readonly Color black = Color.FromArgb(255, 16, 16, 16);

        private readonly Color blue = Color.FromArgb(255, 0, 123, 255);
        private readonly Color indigo = Color.FromArgb(255, 102, 16, 242);
        private readonly Color purple = Color.FromArgb(255, 111, 66, 193);
        private readonly Color pink = Color.FromArgb(255, 232, 62, 140);
        private readonly Color red = Color.FromArgb(255, 220, 53, 69);
        private readonly Color orange = Color.FromArgb(255, 253, 126, 20);
        private readonly Color yellow = Color.FromArgb(255, 255, 193, 7);
        private readonly Color green = Color.FromArgb(255, 40, 167, 69);
        private readonly Color teal = Color.FromArgb(255, 32, 201, 151);
        private readonly Color cyan = Color.FromArgb(255, 23, 162, 184);
        private readonly Color verdeConsola = Color.FromArgb(255, 0, 204, 0);

        private Color[] coloresRand;
        public ColoresARGB()
        {
            this.coloresRand = new Color[10]{ Blue, Indigo, Purple, Pink, Red, Orange, Yellow, Green, Teal, Cyan };
        }

        public Color Primary
        {
            get
            {
                return primary;
            }
        }

        public Color Secondary
        {
            get
            {
                return secondary;
            }
        }

        public Color Success
        {
            get
            {
                return success;
            }
        }

        public Color Info
        {
            get
            {
                return info;
            }
        }

        public Color Warning
        {
            get
            {
                return warning;
            }
        }

        public Color Danger
        {
            get
            {
                return danger;
            }
        }

        public Color Light
        {
            get
            {
                return light;
            }
        }

        public Color Dark
        {
            get
            {
                return dark;
            }
        }

        public Color DarkBackText
        {
            get
            {
                return darkBackText;
            }
        }

        public Color White
        {
            get
            {
                return white;
            }
        }

        public Color Black
        {
            get
            {
                return black;
            }
        }

        public Color Blue
        {
            get
            {
                return blue;
            }
        }

        public Color Indigo
        {
            get
            {
                return indigo;
            }
        }

        public Color Purple
        {
            get
            {
                return purple;
            }
        }

        public Color Pink
        {
            get
            {
                return pink;
            }
        }

        public Color Red
        {
            get
            {
                return red;
            }
        }

        public Color Orange
        {
            get
            {
                return orange;
            }
        }

        public Color Yellow
        {
            get
            {
                return yellow;
            }
        }

        public Color Green
        {
            get
            {
                return green;
            }
        }

        public Color Teal
        {
            get
            {
                return teal;
            }
        }

        public Color Cyan
        {
            get
            {
                return cyan;
            }
        }

        public Color VerdeConsola
        {
            get
            {
                return verdeConsola;
            }
        }

        public Color[] ColoresRand
        {
            get
            {
                return coloresRand;
            }

            set
            {
                coloresRand = value;
            }
        }

        public  Color RandomColor()
        {
            Random Number = new Random();

            int numberRandom = Number.Next(0, 10);
            return ColoresRand[numberRandom];
        }
    }


}
