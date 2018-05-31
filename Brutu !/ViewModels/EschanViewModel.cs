using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using EliteMMO.API;
using static EliteMMO.API.EliteAPI;

namespace Brutu__.ViewModels
{
    public class EschaViewModel : INotifyPropertyChanged
    {
        private readonly IntPtr instance;
        private readonly EliteAPI api;
        private readonly ThirdPartyTools tools;

        public event PropertyChangedEventHandler PropertyChanged;

        string siltpouchtotaltext;
        string beadpouchtotaltext;
        uint silttotal = 0;
        uint beadstotal = 0;
        int selectedindex;
        private ICommand stopClickCommand;
        private ICommand startClickCommand;

        public ICommand StartClickCommand
        {
            get
            {
                return startClickCommand ?? (startClickCommand = new CommandHandler(() => StartUsingItem(), canExecute));
            }
        }

        public ICommand StopClickCommand
        {
            get
            {
                return stopClickCommand ?? (stopClickCommand = new CommandHandler(() => Stop(), canExecute));
            }
        }

        private bool canExecute;
        int progress;
        int progressmax;
        Visibility progressvisibility;
        Visibility stopvisibility;
        string buttontext;
        bool buttonenabled;
        bool isStopped;

        public EschaViewModel(IntPtr instance, EliteAPI api, ThirdPartyTools tools)
        {
            this.instance = instance;
            this.api = api;
            this.tools = tools;
            UpdateItemQuantities();
            canExecute = true;
            ProgressVisibility = Visibility.Hidden;
            Progress = 0;
            ProgressMax = 0;
            ButtonText = "Start";
            ButtonEnabled = true;
            StopVisibility = Visibility.Hidden;
            isStopped = false;
        }

        void Stop()
        {
            isStopped = true;
        }

        void UpdateItemQuantities()
        {
            silttotal = getItemQuantities(6391);
            SiltPouchTotalText = silttotal.ToString() + " found in bag.";
            beadstotal = getItemQuantities(6392);
            BeadPouchTotalText = beadstotal.ToString() + " found in bag.";
        }

        async void StartUsingItem()
        {
            int x = 1;
            string selectedItem = "";
            int timesToRun = 0;
            ButtonText = "Running.";
            ButtonEnabled = false;
            StopVisibility = Visibility.Visible;

            if (selectedindex == 0 && silttotal > 0)
            {
                selectedItem = "Silt Pouch";
                timesToRun = (int)silttotal; 
                ProgressVisibility = Visibility.Visible;

                while (x <= timesToRun)
                {
                    if (!isStopped)
                    {
                        ProgressMax = timesToRun;
                        Progress = x;
                        tools.SendString("/item \"" + selectedItem + "\" <me>");
                        await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 3)));
                        x++;
                    }

                    else
                        x = timesToRun + 1;
                }

            }
            else if (selectedindex == 1 && beadstotal > 0)
            {
                selectedItem = "Bead Pouch";
                timesToRun = (int)beadstotal;
                ProgressVisibility = Visibility.Visible;

                while (x <= timesToRun)
                {
                    if (!isStopped)
                    {
                        ProgressMax = timesToRun;
                        Progress = x;
                        tools.SendString("/item \"" + selectedItem + "\" <me>");
                        await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 3)));
                        x++;
                    }

                    else
                        x = timesToRun + 1;
                }
            }

            else
            {
                //something wasnt selected or there is another problem
            }

            ButtonText = "Start";
            ButtonEnabled = true;
            StopVisibility = Visibility.Hidden;
            isStopped = false;
            UpdateItemQuantities();        
        }

        public Visibility StopVisibility
        {
            get { return stopvisibility; }

            set
            {
                if (stopvisibility != value)
                {
                    stopvisibility = value;
                    RaisePropertyChanged("StopVisibility");
                }
            }
        }

        public bool ButtonEnabled
        {
            get { return buttonenabled; }

            set
            {
                if (buttonenabled != value)
                {
                    buttonenabled = value;
                    RaisePropertyChanged("ButtonEnabled");
                }
            }
        }

        public string ButtonText
        {
            get { return buttontext; }

            set
            {
                if (buttontext != value)
                {
                    buttontext = value;
                    RaisePropertyChanged("ButtonText");
                }
            }
        }

        public int ProgressMax
        {
            get { return progressmax; }

            set
            {
                if (progressmax != value)
                {
                    progressmax = value;
                    RaisePropertyChanged("ProgressMax");
                }
            }
        }

        public Visibility ProgressVisibility
        {
            get { return progressvisibility; }

            set
            {
                if (progressvisibility != value)
                {
                    progressvisibility = value;
                    RaisePropertyChanged("ProgressVisibility");
                }
            }
        }

        public int Progress
        {
            get { return progress; }

            set
            {
                if (progress != value)
                {
                    progress = value;
                    RaisePropertyChanged("Progress");
                }
            }
        }

        public string SiltPouchTotalText
        {
            get { return siltpouchtotaltext; }

            set
            {
                if (siltpouchtotaltext != value)
                {
                    siltpouchtotaltext = value;
                    RaisePropertyChanged("SiltPouchTotalText");
                }
            }
        }

        public string BeadPouchTotalText
        {
            get { return beadpouchtotaltext; }

            set
            {
                if (beadpouchtotaltext != value)
                {
                    beadpouchtotaltext = value;
                    RaisePropertyChanged("BeadPouchTotalText");
                }
            }
        }

        public int SelectedIndex
        {
            get { return selectedindex; }

            set
            {
                if (selectedindex != value)
                {
                    selectedindex = value;
                    RaisePropertyChanged("SelectedIndex");
                }
            }
        }

        uint getItemQuantities(ushort id)
        {
            //silt pouch 6391
            //bead pouch 6392
            uint temp = GetSelectedItemId(instance);
            InventoryTools inventoryTools = new InventoryTools(instance);
            int count = inventoryTools.GetContainerCount(0);
            uint total = 0;

            for (int i = 1; i <= count; i++)
            {
                InventoryItem inventoryItem = new InventoryItem();
                inventoryItem = inventoryTools.GetContainerItem(0, i);

                if (inventoryItem.Id == id)
                    total += inventoryItem.Count;
            }

            return total;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class CommandHandler : ICommand
        {
            private Action _action;
            private bool _canExecute;
            public CommandHandler(Action action, bool canExecute)
            {
                _action = action;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                _action();
            }
        }
    }
}
