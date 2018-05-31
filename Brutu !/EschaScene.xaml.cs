using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;
using Brutu__.ViewModels;


namespace Brutu__
{
    /// <summary>
    /// Interaction logic for EschaScene.xaml
    /// </summary>
    public partial class EschaScene : Page
    {

        public EschaScene()
        {
            InitializeComponent();

            DataContext = new EschaViewModel(MainWindow.ffInstance, MainWindow.api, MainWindow.thirdPartyTools);

        }
    }
}
