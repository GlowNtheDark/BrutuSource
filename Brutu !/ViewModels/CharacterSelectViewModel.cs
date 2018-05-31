using EliteMMO.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using static EliteMMO.API.EliteAPI;

namespace Brutu__.ViewModels
{
    public class CharacterSelectViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler OnRequestClose;

        private const string processName = "pol";
        public Process[] processList = null;
        public static IntPtr ffInstance;
        public static EliteAPI api;
        public static ThirdPartyTools thirdPartyTools;
        public PlayerTools player;
        public string title;
        List<ListBoxItem> items;
        private ICommand goClickCommand;
        private bool canExecute;
        private int listindex = -1;

        public CharacterSelectViewModel()
        {
            processList = Process.GetProcessesByName(processName);
            items = new List<ListBoxItem>();
            canExecute = true;
            Title = "CharacterSelect";

            if (processList.Count() != 0)
            {
                foreach (Process proc in processList)
                {
                    ffInstance = CreateInstance((int)proc.Id);

                    thirdPartyTools = new ThirdPartyTools(ffInstance);
                    api = new EliteAPI((int)proc.Id);
                    player = new PlayerTools(ffInstance, api);
                    ListBoxItem temp = new ListBoxItem();
                    temp.Content = player.Name;
                    items.Add(temp);
                }
            }

            else
            {
                //Title = "Game isn't running, or something's fucked.";
            }
        }

        public void SelectCharacter()
        {
            if(listindex != -1)
            {
                Title = items[listindex].Content.ToString();
                OnRequestClose(this, new EventArgs());
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

        public List<ListBoxItem> Items
        {
            get { return items; }

            set
            {
                if (items != value)
                {
                    items = value;
                    RaisePropertyChanged("Items");
                }
            }
        }

        public string Title
        {
            get { return title; }

            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }

        public ICommand GoClickCommand
        {
            get
            {
                return goClickCommand ?? (goClickCommand = new CommandHandler(() => SelectCharacter(), canExecute));
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
