using _0311library.modelek;
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
using _0311library.adatok;

namespace _0311library.megjelenit
{
    /// <summary>
    /// Interaction logic for torles.xaml
    /// </summary>
    public partial class torles : Page
    {
        megjelenites read = new megjelenites();
        torol delete = new torol();
        public torles()
        {
            InitializeComponent();
            datagrid63.ItemsSource = read.ReadBooks();
        }

        private void Torol_Click(object sender, RoutedEventArgs e)
        {
            var record = datagrid63.CurrentItem as Books;
            var book = delete.DeleteBook(record.Id) as konyvtarResults;
            MessageBox.Show(book.Message);
            datagrid63.ItemsSource = read.ReadBooks();
            delete.DeleteBook(record.Id);
        }
    }
}
