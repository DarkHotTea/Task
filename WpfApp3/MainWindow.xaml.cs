using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using static WpfApp3.MainWindow.Book;

namespace WpfApp3
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
        public class Book
        {
            public string author, title, content;
            public Book(string author, string title, string content)
            {
                this.author = author;  
                this.title = title;
                this.content = content;
            }
            public string Title()
            {
                return title;
            }
            public string Author()
            {
                return author;
            }
            public string Content()
            {
                return content;
            }
        }
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string title = Convert.ToString(TxbX1.Text);
                string author = Convert.ToString(TxbX2.Text);
                string content = Convert.ToString(TxbX3.Text);
                Book book = new Book(title, author, content);
                //Author_Block.Text = $"{book.Author}, {book.Title}, {book.City}";
                Window1 win = new Window1();
                win.Owner = this;
                win.Show();
                win.Author_Block.Text = $"{book.author}";
                win.Name_Block.Text = $"{book.title}";
                win.Text_Block.Text = $"{book.content}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TxbX1.Clear();
            TxbX2.Clear();
            TxbX3.Clear();
        }
    }
}
