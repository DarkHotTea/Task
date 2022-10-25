using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class Address
        {
            double index, apartment;
            string country, city, street, house;
            public Address(double index, double apartment, string country, string city, string street, string house)
            {
                this.index = index;
                this.country = country;
                this.city = city;
                this.street = street;
                this.apartment = apartment;
                this.house = house;
            }
            public double AddressIndex()
            {
                return index;
            }
            public double AddressApartment()
            {
                return apartment;
            }
            public string AddressCountry()
            {
                return country;
            }
            public string AddressCity()
            {
                return city;
            }
            public string AddressStreet()
            {
                return street;
            }
            public string AddressHouse()
            {
                return house;
            }
            public double Index
            {
                get { return AddressIndex(); }
            }
            public double Apartment
            {
                get { return AddressApartment(); }
            }
            public string Country
            {
                get { return AddressCountry(); }
            }
            public string City
            {
                get { return AddressCity(); }
            }
            public string Street
            {
                get { return AddressStreet(); }
            }
            public string House
            {
                get { return AddressHouse(); }
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double index = Convert.ToDouble(TxbX1.Text);
                double apartment = Convert.ToDouble(TxbX6.Text);
                string country = Convert.ToString(TxbX2.Text);
                string city = Convert.ToString(TxbX3.Text);
                string street = Convert.ToString(TxbX4.Text);
                string house = Convert.ToString(TxbX5.Text);
                var address = new Address(index, apartment, country, city, street, house);
                TxbX7.Text =  $"{address.Index}, {address.Country}, {address.City}, {address.Street}, {address.House}, {address.Apartment}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            TxbX1.Clear();
            TxbX2.Clear();
            TxbX3.Clear();
            TxbX4.Clear();
            TxbX5.Clear();
            TxbX6.Clear();
            TxbX7.Clear();
        }
        private void StackPanel_MouseDown(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
