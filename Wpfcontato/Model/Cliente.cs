using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wpfcontato.Model
{
    [Table("TB_Cliente")]
    public class Cliente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }

        public string CPFouCNPJ { get; set; }
        public string telefone { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string CEP { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
