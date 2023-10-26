using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using static System.Net.Mime.MediaTypeNames;

namespace _2510
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

        private void Button_add(object sender, RoutedEventArgs e)
        {
            string text = ValueBox.Text;
            string a = IdBox.Text;

            if (int.TryParse(a, out int index))
            {
                List1.Items.Insert(index,$"{index}. {text}");
            }
            else
            {
               
            }

            ValueBox.Text = "";
            IdBox.Text = "";
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            string a = IdBox.Text;

            if (int.TryParse(a, out int index))
            {
                List1.Items.RemoveAt(index);
            }
            else
            {

            }

            ValueBox.Text = "";
            IdBox.Text = "";
        }
    

        private void IdBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ValueBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            List1.Items.Clear();
        }
    }
}

