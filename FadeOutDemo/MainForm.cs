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
            mainLabel.ForeColor = Color.Black;
            Reset();
        }

        readonly ToolTip _tooltip = new ToolTip();

        private void StartButtonClick(object sender, EventArgs e)
        {
            Reset();
            mainLabel.StartAnimation();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            Reset();
        }

        private void OpacityTrackBarValueChanged(object sender, EventArgs e)
        {
            mainLabel.BackColor = Color.FromArgb(opacityTrackBar.Value, mainLabel.BackColor);
        }

        private void TrackBarScroll(object sender, EventArgs e)
        {
            var ctrl = sender as TrackBar;
            _tooltip.SetToolTip(ctrl, ctrl.Value.ToString());
        }

        private void Reset(object sender = null, EventArgs e = null)
        {
            mainLabel.FadeOutTimerInterval = delayTrackBar.Value;
            mainLabel.FadeoutStep = stepTrackBar.Value;
            mainLabel.StepAcceleration = accTrackBar.Value;
            mainLabel.AnimationFrameInterval = intervalTrackBar.Value;
            opacityTrackBar.Value = 255;
            mainLabel.Visible = true;
            mainLabel.Reset();
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
