using _0311library.adatok;
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

namespace _0311library.megjelenit
{
    /// <summary>
    /// Interaction logic for library.xaml
    /// </summary>
    public partial class library : Page
    {
        megjelenites read = new megjelenites();
        ujhozzaad createBooks = new ujhozzaad();
        private readonly MainWindow _mainWindow;
        public library(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            datagrid1.ItemsSource = read.ReadBooks();
        }

        private void ujhozzadas_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new ujhozzaad());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new torles());
        }

        private void modosit_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new modosit());
        }
    }
}
