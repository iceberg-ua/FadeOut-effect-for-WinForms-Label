using System;
using System.Drawing;
using System.Windows.Forms;

namespace FadeOutDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _tmr.Tick += TimerTick;
            mainLabel.ForeColor = Color.Black;
            Reset();
        }

        readonly Timer _tmr = new Timer();
        readonly ToolTip _tooltip = new ToolTip();

        double _step;
        double _accCoef;

        private void TimerTick(object sender, EventArgs e)
        {
            var a = mainLabel.BackColor.A;

            if (a == 0)
            {
                mainLabel.Visible = false;
                _tmr.Stop();
            }
            else
            {
                mainLabel.BackColor = Color.FromArgb(Math.Max(a - (int)Math.Round(_step), 0), mainLabel.BackColor);
                _step *= _accCoef / 10;
                _tmr.Start();
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            _tmr.Start();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            Reset();
        }

        private void OpacityTrackBarValueChanged(object sender, EventArgs e)
        {
            mainLabel.BackColor = Color.FromArgb(opacityTrackBar.Value, mainLabel.BackColor);
        }

        private void IntervalTrackBarValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void AccTrackBarValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void StepTrackBarValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            _tmr.Stop();
            _tmr.Interval = intervalTrackBar.Value;
            _step = stepTrackBar.Value;
            _accCoef = accTrackBar.Value;
            opacityTrackBar.Value = 255;

            mainLabel.BackColor = Color.FromArgb(opacityTrackBar.Value, mainLabel.BackColor);
            mainLabel.Visible = true;
        }

        private void TrackBarScroll(object sender, EventArgs e)
        {
            var ctrl = sender as TrackBar;
            _tooltip.SetToolTip(ctrl, ctrl.Value.ToString());
        }

        private void ForeColorButtonClick(object sender, EventArgs e)
        {
            using (ColorDialog clrDlg = new ColorDialog())
            {
                var result = clrDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    mainLabel.ForeColor = clrDlg.Color;
                }
            }
        }

        private void BackColorButtonClick(object sender, EventArgs e)
        {
            using (ColorDialog clrDlg = new ColorDialog())
            {
                var result = clrDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    mainLabel.BackColor = clrDlg.Color;
                }
            }
        }
    }
}
