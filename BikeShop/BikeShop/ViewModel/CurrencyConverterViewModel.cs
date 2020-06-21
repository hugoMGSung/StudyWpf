using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.ViewModel
{
    public class CurrencyConverterViewModel : Notifier
    {
        private decimal euros;
        private decimal dollars;

        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }

        public decimal Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged("Dallars");
            }
        }
    }
}
