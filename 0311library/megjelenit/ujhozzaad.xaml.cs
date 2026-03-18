using _0311library.adatok;
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

namespace _0311library.megjelenit
{
    /// <summary>
    /// Interaction logic for ujhozzaad.xaml
    /// </summary>
    public partial class ujhozzaad : Page
    {
        hozzaadas create = new hozzaadas();
        public ujhozzaad()
        {
            InitializeComponent();
        }

        private void hozzaadgomb_Click(object sender, RoutedEventArgs e)
        {
            create.CreateBooks(ujhozzaadTitle.Text,ujhozzaadAuthor.Text,int.Parse(ujhozzaadYear.Text),int.Parse(ujhozzaadPrice.Text));
        }
    }
}
