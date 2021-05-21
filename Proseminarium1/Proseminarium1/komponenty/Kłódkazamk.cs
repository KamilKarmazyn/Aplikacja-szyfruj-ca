using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proseminarium1.komponenty
{
    public partial class Kłódkazamk : Control
    {
        public Kłódkazamk()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // Create image.
            Image newImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/a.jpg");
            float x = 0.0F;
            float y = 0.0F;

            RectangleF srcRect = new RectangleF(1.0F, 10.0F, 36.0F, 36.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;
            pe.Graphics.DrawImage(newImage, x, y, srcRect, units);
        }
    }
    }
    
