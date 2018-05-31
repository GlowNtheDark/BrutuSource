using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutu__.ViewModels
{
    public class TrustItemListViewModel : ObservableCollection<TrustItemViewModel>, IDisposable
    {
        bool disposed;

        public TrustItemListViewModel(string trusts)
        {
            disposed = false;

            string[] splitresult = trusts.Split(',');

            foreach (string str in splitresult)
            {
                Add(new TrustItemViewModel(str));
            }
        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}
