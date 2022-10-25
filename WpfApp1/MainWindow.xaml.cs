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

namespace WpfApp1
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
        public class Rectangle
        {
            double side1, side2;
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double AreaCalculator()
            {
                double S = side1 * side2;
                return S;
            }
            public double PerimeterCalculator()
            {
                double P = (side1 + side2) * 2;
                return P;
            }
            public double Area
            {
                get { return AreaCalculator(); }
            }
            public double Perimeter
            {
                get { return PerimeterCalculator(); }
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = Convert.ToDouble(TxbX.Text);
                double side2 = Convert.ToDouble(TxbX1.Text);
                var rectangle = new Rectangle(side1, side2);
                MessageBox.Show($"Площадь равна: {rectangle.Area}, периметр равен: {rectangle.Perimeter}", "Answer", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                TxbX.Clear();
                TxbX1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                TxbX.Clear();
                TxbX1.Clear();
            }
        }
        private void StackPanel_MouseDown(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}