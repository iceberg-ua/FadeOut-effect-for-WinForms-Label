using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FadeOutDemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitWinHost();
        }

        FadeOutLabel MainLabel;

        private void InitWinHost()
        {
            var panel = new System.Windows.Forms.Panel();
            panel.BackColor = System.Drawing.Color.Azure;
            WinHost.Background = Brushes.Red;
            WinHost.Child = panel;
            ElementHost labelHost = new ElementHost()
            {
                Width = 200,
                Height = 20,
                BackColorTransparent = true,
                BackColor = System.Drawing.Color.Transparent
            };

            MainLabel = new FadeOutLabel(labelHost)
            {
                Content = "Jived fox nymph grabs quick waltz.",
                Width = 200,
                Height = 20,
                Padding = new Thickness(4, 0, 4, 0),
                Background = Brushes.Transparent
            };

            labelHost.Child = MainLabel;
            MainLabel.Visibility = Visibility.Visible;

            var btn = new System.Windows.Forms.Button()
            {
                Location = System.Drawing.Point.Empty,
                Width = 100,
                Height = 100,
                Text = "BUTTON",
                BackColor = System.Drawing.Color.PaleVioletRed
            };

            panel.Controls.Add(btn);
            panel.Controls.Add(labelHost);
            panel.Controls.SetChildIndex(labelHost, 0);

            var hostPanel = new TransparentPanel()
            {
                Width = 400,
                Height = 70,
                BackColor = System.Drawing.Color.Transparent
            };

            //panel.Controls.Add(hostPanel);
            //panel.Controls.SetChildIndex(hostPanel, 0);
            //hostPanel.Controls.Add(labelHost);

            //var labelPanel = new System.Windows.Forms.Panel();
            //labelPanel.BackColor = System.Drawing.Color.Transparent;
            //LabelHost.Background = Brushes.Orange;
            //LabelHost.Child = labelPanel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.StartAnimation();
        }
    }

    class TransparentPanel : System.Windows.Forms.Panel
    {
        public TransparentPanel()
        {
            //SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
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
    }
}
