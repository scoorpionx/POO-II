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
    /// Lógica interna para ViewListarFuncionario.xaml
    /// </summary>
    public partial class ViewListarFuncionario : Window
    {
        public List<Funcionario> Funcionario { get; set; }

        public ViewListarFuncionario()           
        {
            InitializeComponent();

            listarFuncionarios();

            btPesquisar.Click += buscaFuncionarioPorNome;

        }

        public void listarFuncionarios()
        {
            DB database = new DB();
            database.openConnection();
            Funcionario = database.conn.Table<Funcionario>().ToList();
            database.closeConnection();

            dgListaContatos.ItemsSource = Funcionario;
        }

        public void buscaFuncionarioPorNome(object sender, RoutedEventArgs e)
        {
            if(txtNomePesquisa.Text == "")
            {
                listarFuncionarios();
                return;
            };

            DB database = new DB();
            database.openConnection();
            Funcionario = database.conn.Query<Funcionario>("SELECT * FROM `TB_Funcionario` WHERE `TB_Funcionario`.`Nome` LIKE ? ", txtNomePesquisa.Text).ToList();
            database.closeConnection();
            dgListaContatos.ItemsSource = Funcionario;
        }
    }
}
