using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using BusinessLogic;

using System.ComponentModel;

namespace BikeShop
{
    public partial class Test : Page
    {
        public Test()
        {
            InitializeComponent();
            Inits();
        }

        private void Inits()
        {
            //myCar.Color = Colors.Blue;
            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                var car = new Car();
                car.Speed = i * 10;
                if (i % 3 == 0)         car.Color = Colors.Red;
                else if (i % 3 == 1)    car.Color = Colors.Green;
                else                    car.Color = Colors.Blue;

                cars.Add(car);
            }
            this.DataContext = cars;
        }

        private void Greet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hell");
        }

        private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid MouseLeft");
        }

        private void Button_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First Button MouseLeft");
        }

        private void Button_MouseLeftButtonDown_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Second Button MouseLeft");
        }
    }
}

namespace Maths
{
    public class TwiceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((int)value) * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
