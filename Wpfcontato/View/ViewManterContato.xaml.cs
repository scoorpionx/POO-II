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
    /// Lógica interna para ViewManterContato.xaml
    /// </summary>
    public partial class ViewManterContato : Window
    {
        public ViewManterContato()
        {
            InitializeComponent();
        }

        private void btxSalvar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nome = txbName.Text,
                Email = tbxEmail.Text,
                NomeEmpresa = tbxEmpresa.Text,
                Cep = tbxCep.Text,
                Endereco = tbxEndereco.Text,
                Telefone = tbxTelefone.Text,
                Celular = tbxCelular.Text

            };
            DB database = new DB();
            database.openConnection();
            database.conn.Insert(Cliente);
            database.closeConnection();
            this.Close();
        }
    }
}

