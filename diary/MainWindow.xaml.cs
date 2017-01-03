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

namespace diary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBoxToday.ItemsSource = App.today;
            listBoxInList.ItemsSource = App.inList;
            listBoxFinished.ItemsSource = App.finished;
        }

        private void addToday_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine();
            //App.today.Remove((Tasks)listBoxToday.SelectedItem);
        }

        private void changeToday_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteToday_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addInList_Click(object sender, RoutedEventArgs e)
        {

        }
        private void changeInList_Click(object sender, RoutedEventArgs e)
        {

        }
        private void deleteInList_Click(object sender, RoutedEventArgs e)
        {
            App.inList.Remove((Tasks)listBoxInList.SelectedItem);
        }

        private void addFinished_Click(object sender, RoutedEventArgs e)
        {

        }

        private void changeFinished_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteFinished_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
