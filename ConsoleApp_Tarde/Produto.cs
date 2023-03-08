using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Produto
    {
        public Produto(string descricao, int id, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        private int Id;
        private string Descricao;
        private decimal Valor;
        public string getDescricao()
        {
            return "Descrição do produto: " + Descricao;
        }
        public string getValor()
        {
            return "Valor em R$ " + Valor;
        }
        public string getId()
        {
            return "Código:" + Id;
        }

    }
}
