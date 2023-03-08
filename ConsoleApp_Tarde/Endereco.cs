using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Endereco
    {
        private int Id;
        private string CEP;
        private string Rua;
        private int Numero;
        private string Bairro;
        private string Cidade;

        public Endereco(int id, string cep, string rua, int numero, string bairro, string cidade)
        {
            Id = id;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
        public int getId() {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getCEP()
        {
            return CEP;
        }
        public void setCEP(string cep) 
        {
            CEP = cep;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}
