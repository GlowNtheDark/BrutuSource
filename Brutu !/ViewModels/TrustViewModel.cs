using EliteMMO.API;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Brutu__.ViewModels
{
    public class TrustViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IntPtr instance;
        private readonly EliteAPI api;
        private readonly ThirdPartyTools tools;
        public TrustUserListViewModel tulviewmodel;
        public TrustItemListViewModel tilviewmodel;

        public bool savebuttonenabled;
        public bool listremovebuttonenabled;
        public bool trustremovebuttonenabled;
        public bool summonbuttonenabled;
        public string toptext;
        private bool canexecute;
        private int listindex;
        private int trustindex;


        public TrustViewModel(IntPtr instance, EliteAPI api, ThirdPartyTools tools)
        {
            this.instance = instance;
            this.api = api;
            this.tools = tools;
            TopText = "Save file not loaded.";
            SaveButtonEnabled = false;
            ListRemoveButtonEnabled = false;
            TrustRemoveButtonEnabled = false;
            SummonButtonEnabled = false;
            canexecute = true;
        }

        public void ItemClicked()
        {
            TilViewModel = TulViewModel[ListIndex].TilViewModel;
        }

        public void OpenClicked()
        {
            string[] readoutput;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Dic files (*.dic)|*.dic|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            readoutput = File.ReadAllLines(openFileDialog.FileName);

            TulViewModel = new TrustUserListViewModel(readoutput);

            TopText = openFileDialog.SafeFileName + " loaded.";
 
            SaveButtonEnabled = true;
            ListRemoveButtonEnabled = true;
            TrustRemoveButtonEnabled = true;
            SummonButtonEnabled = true;
        }

        public TrustItemListViewModel TilViewModel
        {
            get { return tilviewmodel; }

            set
            {
                if (tilviewmodel != value)
                {
                    tilviewmodel = value;
                    RaisePropertyChanged("TilViewModel");
                }
            }
        }

        public TrustUserListViewModel TulViewModel
        {
            get { return tulviewmodel; }

            set
            {
                if (tulviewmodel != value)
                {
                    tulviewmodel = value;
                    RaisePropertyChanged("TulViewModel");
                }
            }
        }

        private ICommand itemclickcommand;

        public ICommand ItemClickCommand
        {
            get
            {
                return itemclickcommand ?? (itemclickcommand = new CommandHandler(() => ItemClicked(), canexecute));
            }
        }

        private ICommand openclickcommand;

        public ICommand OpenClickCommand
        {
            get
            {
                return openclickcommand ?? (openclickcommand = new CommandHandler(() => OpenClicked(), canexecute));
            }
        }

        public int TrustIndex
        {
            get { return trustindex; }

            set
            {
                if (trustindex != value)
                {
                    trustindex = value;
                    RaisePropertyChanged("TrustIndex");
                }
            }
        }

        public int ListIndex
        {
            get { return listindex; }

            set
            {
                if (listindex != value)
                {
                    listindex = value;
                    RaisePropertyChanged("ListIndex");
                }
            }
        }

        public string TopText
        {
            get { return toptext; }

            set
            {
                if (toptext != value)
                {
                    toptext = value;
                    RaisePropertyChanged("TopText");
                }
            }
        }

        public bool SummonButtonEnabled
        {
            get { return summonbuttonenabled; }

            set
            {
                if (summonbuttonenabled != value)
                {
                    summonbuttonenabled = value;
                    RaisePropertyChanged("SummonButtonEnabled");
                }
            }
        }

        public bool TrustRemoveButtonEnabled
        {
            get { return trustremovebuttonenabled; }

            set
            {
                if (trustremovebuttonenabled != value)
                {
                    trustremovebuttonenabled = value;
                    RaisePropertyChanged("TrustRemoveButtonEnabled");
                }
            }
        }

        public bool ListRemoveButtonEnabled
        {
            get { return listremovebuttonenabled; }

            set
            {
                if (listremovebuttonenabled != value)
                {
                    listremovebuttonenabled = value;
                    RaisePropertyChanged("ListRemoveButtonEnabled");
                }
            }
        }

        public bool SaveButtonEnabled
        {
            get { return savebuttonenabled; }

            set
            {
                if (savebuttonenabled != value)
                {
                    savebuttonenabled = value;
                    RaisePropertyChanged("SaveButtonEnabled");
                }
            }
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
