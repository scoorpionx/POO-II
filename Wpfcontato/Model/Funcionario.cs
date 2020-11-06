using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wpfcontato.Model

    
    {
        [Table("TB_Funcionario")]
        public class Funcionario
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Nome { get; set; }
            public string CPFouCNPJ { get; set; }
            public string Telefone { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string CEP { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
        }
    }

