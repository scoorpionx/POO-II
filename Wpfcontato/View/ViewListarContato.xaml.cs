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
using System.Linq;

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

            btPesquisar.Click += buscaClientePorNome;
        }

        public void listarContatos()
        {
            DB database = new DB();
            database.openConnection();
            Cliente = database.conn.Table<Cliente>().ToList();
            database.closeConnection();

            dgListaContatos.ItemsSource = Cliente;
        }

        public void buscaClientePorNome(object sender, RoutedEventArgs e)
        {
            if (txtNomePesquisa.Text == "")
            {
                listarContatos();
                return;
            };

            DB database = new DB();
            database.openConnection();
            Cliente = database.conn.Query<Cliente>("SELECT * FROM `TB_Cliente` WHERE `TB_Cliente`.`Nome` LIKE ? ", txtNomePesquisa.Text).ToList();
            database.closeConnection();
            dgListaContatos.ItemsSource = Cliente;
        }
    }

}
