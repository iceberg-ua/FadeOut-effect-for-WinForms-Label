using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FadeOutDemo
{
    class CustomLabel : Label
    {
        public CustomLabel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT = 0x00000020
                return param;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var bmp = new Bitmap(Width, Height, PixelFormat.Format32bppPArgb);

            using (var grfx = Graphics.FromImage(bmp))
            {
                grfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                grfx.Clear(BackColor);
                var args = new PaintEventArgs(grfx, e.ClipRectangle);
                base.OnPaint(args);
            }

            short a = BackColor.A;

            if (a != 255)
            {
                for (int y = 0; y < Height - 1; y++)
                {
                    for (int x = 0; x < Width - 1; x++)
                    {
                        var pxColor = bmp.GetPixel(x, y);

                        if (pxColor.A != a)
                            bmp.SetPixel(x, y, Color.FromArgb(a, pxColor));
                    }
                }
            }

            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
