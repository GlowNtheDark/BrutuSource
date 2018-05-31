using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Brutu__.ViewModels;
using EliteMMO.API;
using static EliteMMO.API.EliteAPI;

namespace Brutu__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IntPtr ffInstance;
        public static EliteAPI api;
        public static ThirdPartyTools thirdPartyTools;
        public Process[] processList = null;
        private const string processName = "pol";

        public MainWindow()
        {
            InitializeComponent();

            if (!IsRunningAsAdministrator())
            {
                // Setting up start info of the new process of the same application
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);

                // Using operating shell and setting the ProcessStartInfo.Verb to “runas” will let it run as admin
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";

                // Start the application as new process
                Process.Start(processStartInfo);

                // Shut down the current (old) process
                Application.Current.Shutdown();
            }
            else
            {
                Window CharacterWindow = new CharacterSelectWindow();
                CharacterSelectViewModel vm = (CharacterSelectViewModel)CharacterWindow.DataContext;
                vm.OnRequestClose += (s, e) => CharacterWindow.Close();
                CharacterWindow.ShowDialog();
                this.Title = CharacterWindow.Title;

                if (Title != "CharacterSelect")
                {

                    processList = Process.GetProcessesByName(processName);

                    foreach (Process proc in processList)
                    {
                        if (proc.MainWindowTitle == this.Title)
                        {
                            ffInstance = CreateInstance((int)proc.Id);
                            thirdPartyTools = new ThirdPartyTools(ffInstance);
                            api = new EliteAPI((int)proc.Id);
                        }

                    }
                }

                else
                {
                    MessageBox.Show("A character wasn't selected or the game isn't running.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    this.Close();
                }
            }

        }

        public static bool IsRunningAsAdministrator()
        {
            // Get current Windows user
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();

            // Get current Windows user principal
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);

            // Return TRUE if user is in role "Administrator"
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void ListViewItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel sp = sender as StackPanel;

            LoadFrame(sp.Name);
        }

        public void LoadFrame(string frameName)
        {
            if (frameName == "eschaSP")
            {
                mainFrame.Navigate(new System.Uri("EschaScene.xaml",UriKind.RelativeOrAbsolute));
            }
            else if (frameName == "znmSP")
            {
                mainFrame.Navigate(new System.Uri("ZnmScene.xaml", UriKind.RelativeOrAbsolute));
            }
            else if (frameName == "trustSP")
            {
                mainFrame.Navigate(new System.Uri("TrustScene.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
