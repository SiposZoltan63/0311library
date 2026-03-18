using _0311library.megjelenit;
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
using System.Windows.Shapes;

namespace _0311library
{
    /// <summary>
    /// Interaction logic for library.xaml
    /// </summary>
    public partial class library : Window
    {
        //Read read = new Read();
        ujhozzaad createBooks = new ujhozzaad();
        private readonly MainWindow _mainWindow;
        public library(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
    }
}
