using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutu__.ViewModels
{
    public class TrustUserListViewModel : ObservableCollection<TrustUserItemViewModel>, IDisposable
    {
        bool disposed;

        public TrustUserListViewModel(string[] readoutput)
        {
            disposed = false;

            foreach (string str in readoutput)
            {
                string[] splitresult = str.Split(';');

                Add(new TrustUserItemViewModel(splitresult[0], splitresult[1]));
            }

        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}
