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
    /// Interaction logic for modosit.xaml
    /// </summary>
    public partial class modosit : Page
    {
        megjelenites read = new megjelenites();
        public modosit()
        {
            InitializeComponent();
            datagrid2.ItemsSource = read.ReadBooks();
        }
    }
}
