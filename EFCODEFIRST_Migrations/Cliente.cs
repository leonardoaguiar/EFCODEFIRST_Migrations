using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFCODEFIRST_Migrations
{
    [Table("Clientes")]
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal Limite { get; set; }
    }

    [Table("Enderecos")]
    public class Endereco
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

    [Table("Produtos")]
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }        
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime validade { get; set; }
        public string Comentarios { get; set; }
    }

    [Table("Pessoas")]
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }

    [Table("Gente")]
    public class Gente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
