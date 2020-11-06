﻿using System;
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
                CPFouCNPJ = tbxCPFouCNPJ.Text,
                Logradouro = tbxLogradouro.Text,
                CEP = tbxCEP.Text,
                Numero = tbxNumero.Text,
                Telefone = tbxTelefone.Text,
                Complemento = tbxComplemento.Text,
                Bairro = tbxBairro.Text,
                Cidade = tbxCidade.Text,
                Estado = tbxEstado.Text

            };
            DB database = new DB();
            database.openConnection();
            database.conn.Insert(cliente);
            database.closeConnection();
            this.Close();
        }
    }
}

