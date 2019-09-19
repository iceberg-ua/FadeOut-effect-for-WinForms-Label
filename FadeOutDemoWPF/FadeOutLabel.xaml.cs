using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FadeOutDemoWPF
{
    /// <summary>
    /// Interaction logic for FadeOutLabel.xaml
    /// </summary>
    public partial class FadeOutLabel : Label
    {
        readonly ElementHost _owner;

        public FadeOutLabel(ElementHost owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        public void StartAnimation()
        {
            _owner.Visible = true;
            Visibility = Visibility.Visible;
            Opacity = 0;

            DoubleAnimation anime = new DoubleAnimation(1, 0, new Duration(new TimeSpan(5000000)));
            anime.AccelerationRatio = .9;
            anime.Completed += AnimeCompleted;
            BeginAnimation(OpacityProperty, anime);
        }

        private void AnimeCompleted(object sender, EventArgs e)
        {
            _owner.Visible = false;
        }
    }
}
