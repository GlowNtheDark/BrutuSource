using Brutu__.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Brutu__
{
    /// <summary>
    /// Interaction logic for TrustScene.xaml
    /// </summary>
    public partial class TrustScene : Page
    {
        public static TrustScene Current;
        public TrustScene()
        {
            DataContext = new TrustViewModel(MainWindow.ffInstance, MainWindow.api, MainWindow.thirdPartyTools);
            InitializeComponent();
        }
    }
}
