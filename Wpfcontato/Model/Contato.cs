using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wpfcontato.Model
{
    [Table("TB_Contato")]
    public class  Contato
    {
        [PrimaryKey, AutoIncrement]
        
        public int Id { get; set; }
        public string Nome { get; set; }
     
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string NomeEmpresa { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
