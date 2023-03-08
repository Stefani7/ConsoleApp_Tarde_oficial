using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        public string getId()
        {
            return "Código:" + Id;
        }

        public void setId(int id) 
        {
            Id = id;
        }
        public string getDescricao()
        {
            return "Descrição do produto: " + Descricao;
        }
        public void setDescricao(string descricao) 
        {
            Descricao = descricao;
        }
        public string getValor()
        {
            return "Valor em R$ " + Valor;
        }

        public void setValor(decimal valor)
        {
            if (valor > 0)
            {
                Valor = valor;
            }
        }

    }
}
