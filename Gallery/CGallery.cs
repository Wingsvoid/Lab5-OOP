using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gallery.Properties;

namespace Gallery
{
    public class Images
    {
        public Bitmap bitmap;
        public string visibleText;
        public string text = "";
        public Images() { }

        public Images(Bitmap bitmap, string visibleText)
        {
            this.bitmap = bitmap;
            this.visibleText = visibleText;
        }
    }

    class CGallery : HoverButton
    {
        private int i = 0;

        public Color hoverColor = Color.FromArgb(0, Color.Black);

        public List<Images> gallery = new List<Images>();

        public CGallery() : base()
        {
            gallery.Add(new Images(new Bitmap(Resources.img1), "Весна"));
            gallery.Add(new Images(new Bitmap(Resources.img2), "Лето"));
            gallery.Add(new Images(new Bitmap(Resources.img3), "Осень"));
            gallery.Add(new Images(new Bitmap(Resources.img4), "Зима"));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawImage(gallery[i].bitmap, 0, 0);

            stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            pe.Graphics.FillRectangle(new SolidBrush(hoverColor), ClientRectangle);

            pe.Graphics.DrawString(gallery[i].text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            gallery[i].text = gallery[i].visibleText;
            hoverColor = Color.FromArgb(100, Color.Black);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            gallery[i].text = "";
            hoverColor = Color.FromArgb(0, Color.Black);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;

            if (i > gallery.Count - 1)
                i = 0;

            OnMouseEnter(new EventArgs());
        }
    }
}
