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
using Wpfcontato.View;
using Wpfcontato.DAO;

namespace Wpfcontato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DB database = new DB();
            database.createTables();
            InitializeComponent();
        }

        private void mNovo_Click(object sender, RoutedEventArgs e)
        {
            var manterContato = new ViewManterContato();
          
            manterContato.Show();
        }

        private void mListar_Click(object sender, RoutedEventArgs e)
        {
            var ListarContato = new ViewListarContato();

            ListarContato.Show();
        }
    }
}
