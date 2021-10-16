﻿using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Serialport.Class
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
