using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpfcontato.Model;
using Wpfcontato.DAO;

namespace Wpfcontato.View
{
    /// <summary>
    /// Lógica interna para ViewListarContato.xaml
    /// </summary>
    public partial class ViewListarContato : Window
    {
        public List<Cliente> Cliente { get; set; }
        public ViewListarContato()
        {
            InitializeComponent();

            listarContatos();

            dgListaContatos.ItemsSource = Contatos;
            
        }

        public void listarContatos()
        {
            DB database = new DB();
            database.openConnection();
            Clientes = database.conn.Table<Cliente>().ToList();
            database.closeConnection();

        }

    }

}
