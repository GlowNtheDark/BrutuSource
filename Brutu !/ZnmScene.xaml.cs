using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Brutu__.ViewModels;
using EliteMMO.API;
using static EliteMMO.API.EliteAPI;

namespace Brutu__
{
    /// <summary>
    /// Interaction logic for ZnmScene.xaml
    /// </summary>
    public partial class ZnmScene : Page
    {
        public ZnmScene()
        {
            InitializeComponent();

            DataContext = new ZnmViewModel(MainWindow.ffInstance, MainWindow.api, MainWindow.thirdPartyTools);

        }
        /* Trade all soul plates.
         * 
         * Auto equip plates when stack runs out.
         * Auto equip trapper and stacks.
         * Use charges of new or old camera.
         * Use both camera versions.
         * 
         */
    }
}
