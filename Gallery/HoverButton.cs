using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    class HoverButton : Button
    {
        protected StringFormat stringFormat;

        public HoverButton() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
            20.25F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            0);
        }
        
    }
}
