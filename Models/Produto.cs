using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_CONSOLE.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];
            //verificamos se a pasta não existe e criamos nesta condição
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //Verificamos se o arquivo Produto.csv existe, caso não exista,vamos crialo
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        internal void ListarTodos(List<Produto> todos)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ler()
        {
            List<Produto> produtos = new List<Produto>();


            //pegar as informações do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas)
            {

                   //Separar atribtos pelo ; 
                 string[] atributos = item.Split(";");

                  //Criamos um Produto vazio para poder colocar na lista de produtos
                 Produto prod = new Produto();
                 prod.Codigo  = int.Parse(atributos[0]);
                 prod.Nome    = atributos[1];
                 prod.Preco   = float.Parse(atributos[2]);
                 
                 produtos.Add(prod);


           

            }


            return produtos;
        }
        
        
    }
}