using EliteMMO.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static EliteMMO.API.EliteAPI;

namespace Brutu__.ViewModels
{

    public class ZnmViewModel : INotifyPropertyChanged
    {
        private readonly IntPtr instance;
        private readonly EliteAPI api;
        private readonly ThirdPartyTools tools;

        uint blanksoulplatecount;
        uint soulplatecount;
        Visibility nqtrapperfound;
        Visibility hqtrapperfound;
        int selectedindex;
        int trapperprogress;
        int trapperprogressmax;
        int tradeprogress;
        int tradeprogressmax;
        Visibility trappergridvisibilty;
        Visibility tradegridvisibilty;
        bool trapperbuttonenabled;
        bool tradebuttonenabled;
        private bool canexecute;
        string trapperbuttontext;
        string tradebuttontext;

        private ICommand trapperclickcommand;

        public ICommand TrapperClickCommand
        {
            get
            {
                return trapperclickcommand ?? (trapperclickcommand = new CommandHandler(() => StartClicked(), canexecute));
            }
        }

        private ICommand tradeclickcommand;

        public ICommand TradeClickCommand
        {
            get
            {
                return tradeclickcommand ?? (tradeclickcommand = new CommandHandler(() => TradeClicked(), canexecute));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ZnmViewModel(IntPtr instance, EliteAPI api, ThirdPartyTools tools)
        {
            this.instance = instance;
            this.api = api;
            this.tools = tools;
            canexecute = true;
            TrapperButtonEnabled = true;
            TradeButtonEnabled = true;
            TrapperButtonText = "Start";
            TradeButtonText = "Trade";
            BlankSoulPlateCount = GetItemQuantities(18722);
            SoulPlateCount = GetItemQuantities(2477);
            uint result1 = GetItemQuantities(18721);
            uint result2 = GetItemQuantities(18724);
            TrapperGridVisibilty = Visibility.Hidden;
            TradeGridVisibilty = Visibility.Hidden;

            if (result1 > 0)
                NqTrapperFound = Visibility.Visible;
            else
                NqTrapperFound = Visibility.Hidden;
            if (result2 > 0)
                NqTrapperFound = Visibility.Visible;
            else
                HqTrapperFound = Visibility.Hidden;
        }

        async void StartClicked()
        {
            BlankSoulPlateCount = GetItemQuantities(18722);
            string selectedItem = "";

            if (selectedindex == 0 && BlankSoulPlateCount > 0)
            {
                selectedItem = "Soultrapper";
                TrapperGridVisibilty = Visibility.Visible;
                TrapperButtonEnabled = false;
                TrapperButtonText = "Running";
                tools.SendString("/equip range " + selectedItem);
                tools.SendString("/equip ammo \"Blank Soul Plate\"");
                TrapperProgressMax = 12;

                await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 1))); //need a wait between equip and use of trapper

                for (int i = 1; i <= 12; i++)
                {

                    tools.SendString("/item \"" + selectedItem + "\" <t>");
                    BlankSoulPlateCount = GetItemQuantities(18722);
                    TrapperProgress = i;
                    if (BlankSoulPlateCount == 0)
                        i = 12;

                    await Task.Run(() => Thread.Sleep(new TimeSpan(0, 1, 5)));
                }
            }
            else if (selectedindex == 1 && BlankSoulPlateCount > 0)
            {
                TrapperProgressMax = 48;
                selectedItem = "Soultrapper 2000";
                TrapperGridVisibilty = Visibility.Visible;
                TrapperButtonEnabled = false;
                TrapperButtonText = "Running";
                tools.SendString("/equip range " + selectedItem);
                tools.SendString("/equip ammo \"Blank Soul Plate\"");

                await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 1))); //need a wait between equip and use of trapper

                for (int i = 1; i <= 48; i++)
                {
                    tools.SendString("/item \"" + selectedItem + "\" <t>");
                    BlankSoulPlateCount = GetItemQuantities(18722);
                    TrapperProgress = i;
                    if (BlankSoulPlateCount == 0)
                        i = 48;

                    await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 35)));
                }
            }

            TrapperGridVisibilty = Visibility.Hidden;
            TrapperButtonEnabled = true;
            TrapperButtonText = "Start";
        }

        async void TradeClicked()
        {
            SoulPlateCount = GetItemQuantities(2477);
            TradeButtonText = "Running";
            TradeButtonEnabled = false;

            int i = 1;
            TradeProgressMax = (int)SoulPlateCount;
            TradeGridVisibilty = Visibility.Visible;

            while (i <= SoulPlateCount)
            {
                tools.SendString("/targetnpc");
                await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 1))); //need a wait between commands
                if (IsSanrakuSelected())
                {
                    TradeProgress = i;
                    tools.SendString("/item \"Soul Plate\" <t>");
                    await Task.Run(() => Thread.Sleep(new TimeSpan(0, 0, 5)));
                    i++;
                }
            }

            TradeGridVisibilty = Visibility.Hidden;
            TradeButtonText = "Trade";
            TradeButtonEnabled = true;
        }
    

        public string TradeButtonText
        {
            get { return tradebuttontext; }

            set
            {
                if (tradebuttontext != value)
                {
                    tradebuttontext = value;
                    RaisePropertyChanged("TradeButtonText");
                }
            }
        }

        public string TrapperButtonText
        {
            get { return trapperbuttontext; }

            set
            {
                if (trapperbuttontext != value)
                {
                    trapperbuttontext = value;
                    RaisePropertyChanged("TrapperButtonText");
                }
            }
        }

        public bool TradeButtonEnabled
        {
            get { return tradebuttonenabled; }

            set
            {
                if (tradebuttonenabled != value)
                {
                    tradebuttonenabled = value;
                    RaisePropertyChanged("TradeButtonEnabled");
                }
            }
        }

        public bool TrapperButtonEnabled
        {
            get { return trapperbuttonenabled; }

            set
            {
                if (trapperbuttonenabled != value)
                {
                    trapperbuttonenabled = value;
                    RaisePropertyChanged("TrapperButtonEnabled");
                }
            }
        }

        public Visibility TradeGridVisibilty
        {
            get { return tradegridvisibilty; }

            set
            {
                if (tradegridvisibilty != value)
                {
                    tradegridvisibilty = value;
                    RaisePropertyChanged("TradeGridVisibilty");
                }
            }
        }

        public Visibility TrapperGridVisibilty
        {
            get { return trappergridvisibilty; }

            set
            {
                if (trappergridvisibilty != value)
                {
                    trappergridvisibilty = value;
                    RaisePropertyChanged("TrapperGridVisibilty");
                }
            }
        }

        public int TrapperProgressMax
        {
            get { return trapperprogressmax; }

            set
            {
                if (trapperprogressmax != value)
                {
                    trapperprogressmax = value;
                    RaisePropertyChanged("TrapperProgressMax");
                }
            }
        }

        public int TrapperProgress
        {
            get { return trapperprogress; }

            set
            {
                if (trapperprogress != value)
                {
                    trapperprogress = value;
                    RaisePropertyChanged("TrapperProgress");
                }
            }
        }

        public int TradeProgressMax
        {
            get { return tradeprogressmax; }

            set
            {
                if (tradeprogressmax != value)
                {
                    tradeprogressmax = value;
                    RaisePropertyChanged("TradeProgressMax");
                }
            }
        }

        public int TradeProgress
        {
            get { return tradeprogress; }

            set
            {
                if (tradeprogress != value)
                {
                    tradeprogress = value;
                    RaisePropertyChanged("TradeProgress");
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

        public Visibility HqTrapperFound
        {
            get { return hqtrapperfound; }

            set
            {
                if (hqtrapperfound != value)
                {
                    hqtrapperfound = value;
                    RaisePropertyChanged("HqTrapperFound");
                }
            }
        }

        public Visibility NqTrapperFound
        {
            get { return nqtrapperfound; }

            set
            {
                if (nqtrapperfound != value)
                {
                    nqtrapperfound = value;
                    RaisePropertyChanged("NqTrapperFound");
                }
            }
        }

        public uint BlankSoulPlateCount
        {
            get { return blanksoulplatecount; }

            set
            {
                if (blanksoulplatecount != value)
                {
                    blanksoulplatecount = value;
                    RaisePropertyChanged("BlankSoulPlateCount");
                }
            }
        }

        public uint SoulPlateCount
        {
            get { return soulplatecount; }

            set
            {
                if (soulplatecount != value)
                {
                    soulplatecount = value;
                    RaisePropertyChanged("SoulPlateCount");
                }
            }
        }

        uint GetItemQuantities(ushort id)
        {
            //silt pouch 6391
            //bead pouch 6392
            //Trapper2000 id = 18724
            //Blank soulplate id = 18722
            //Soultrapper id = 18721
            //Soul Plate id = 2477
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

        bool IsSanrakuSelected()
        {
            TargetTools targetTools = new TargetTools(MainWindow.ffInstance);
            TargetInfo target = new TargetInfo();
            target = targetTools.GetTargetInfo();

            if (target.TargetName == "Sanraku")
                return true;
            else
                return false;
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
