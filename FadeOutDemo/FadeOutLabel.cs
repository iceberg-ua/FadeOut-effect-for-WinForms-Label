using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FadeOutDemo
{
    class FadeOutLabel : Label
    {
        public FadeOutLabel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.Transparent;

            _fadeoutTimer.Interval = 1500;
            _fadeoutTimer.Tick += StartAnimation;

            _animationTimer.Interval = 25;
            _animationTimer.Tick += AnimationFrame;
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var param = base.CreateParams;
        //        param.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT = 0x00000020
        //        return param;
        //    }
        //}

        Timer _fadeoutTimer = new Timer();
        Timer _animationTimer = new Timer();
        decimal _currentStep;

        #region Properties

        public override string Text
        {
            get { return base.Text; }
            set
            {
                Reset();
                base.Text = value;
                StartAnimation();
            }
        }

        private int _opacity = 255;

        public int Opacity
        {
            get { return _opacity; }
            set
            {
                _opacity = value;
                Invalidate();
            }
        }

        private Brush _background = SystemBrushes.Control;

        public Brush Background
        {
            get { return _background; }
            set
            {
                _background = value;
                Invalidate();
            }
        }

        public int FadeOutTimerInterval
        {
            get { return _fadeoutTimer.Interval; }
            set { _fadeoutTimer.Interval = value; }
        }

        public int AnimationFrameInterval
        {
            get { return _animationTimer.Interval; }
            set { _animationTimer.Interval = value; }
        }

        public int FadeoutStep { get; set; }

        public decimal StepAcceleration { get; set; }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            if (Parent != null)
            {
                using (var behind = new Bitmap(Parent.Width, Parent.Height))
                {

                    foreach (Control c in Parent.Controls)
                        if (c.Bounds.IntersectsWith(Bounds) & c != this)
                            c.DrawToBitmap(behind, c.Bounds);

                    pevent.Graphics.DrawImage(behind, -Left, -Top);
                }
            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var bmp = new Bitmap(Width, Height))
            {
                using (var grfx = Graphics.FromImage(bmp))
                {
                    int x = Padding.Left + Margin.Left;
                    int y = Padding.Top + Margin.Top;

                    grfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    grfx.FillRectangle(Background, new RectangleF(0, 0, Width, Height));
                    grfx.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(x, y));
                }

                if (Opacity != 255)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        for (int x = 0; x < Width; x++)
                        {
                            var pxColor = bmp.GetPixel(x, y);

                            if (pxColor.A != Opacity)
                                bmp.SetPixel(x, y, Color.FromArgb(Opacity, pxColor));
                        }
                    }
                }

                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            _currentStep = FadeoutStep;
            _fadeoutTimer.Stop();
            _animationTimer.Start();
        }

        private void AnimationFrame(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Visible = false;
                _animationTimer.Stop();
            }

            if (Visible)
            {
                Opacity = Math.Max(Opacity - (int)Math.Round(_currentStep), 0);
                _currentStep *= StepAcceleration / 10;
            }
        }

        public void StartAnimation()
        {
            _fadeoutTimer.Start();
        }

        public void Reset()
        {
            _animationTimer.Stop();
            _fadeoutTimer.Stop();

            Opacity = 255;
        }
    }
}
