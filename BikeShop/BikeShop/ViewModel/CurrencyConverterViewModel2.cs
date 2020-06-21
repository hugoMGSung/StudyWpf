using System;
using System.Collections.Generic;

namespace BikeShop.ViewModel
{
    public class Currency
    {
        public string Title { get; set; }
        public decimal Rate { get; set; }

        public Currency(string title, decimal rate)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Rate = rate;
        }
    }
    public class CurrencyConverterViewModel2 : Notifier
    {
        // 무시할 수 있는 장황한 코드
        private decimal euros;
        private decimal converted;
        private Currency selectedCurrency;
        private IEnumerable<Currency> currencies;
        private string resultText;

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

        public decimal Converted
        {
            get { return converted; }
            set
            {
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChanged();
            }
        }

        public IEnumerable<Currency> Currencies
        {
            get { return currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged("Currencies");
            }
        }

        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }

        // 생성자!!
        public CurrencyConverterViewModel2()
        {
            Currencies = new Currency[]
            {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", 0.9M),
            };
        }

        private void OnEurosChanged()
        {
            ComputeConverted();
        }

        private void OnSelectedCurrencyChanged()
        {
            ComputeConverted();
        }

        private void ComputeConverted()
        {
            if (SelectedCurrency == null)
                return;

            Converted = Euros * SelectedCurrency.Rate;
            ResultText = string.Format($"Amount in {SelectedCurrency.Title}");
        }
    }
}
