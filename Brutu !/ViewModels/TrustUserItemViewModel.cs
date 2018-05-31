using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutu__.ViewModels
{
    public class TrustUserItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string name;
        TrustItemListViewModel tilviewmodel;

        public TrustUserItemViewModel(string name, string trusts)
        {
            this.Name = name;

            TilViewModel = new TrustItemListViewModel(trusts);
        }

        public TrustItemListViewModel TilViewModel
        {
            get { return tilviewmodel; }

            private set
            {
                if (tilviewmodel != value)
                {
                    tilviewmodel = value;
                    RaisePropertyChanged("TilViewModel");
                }
            }
        }

        public string Name
        {
            get { return name; }

            private set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
