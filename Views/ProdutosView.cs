using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE.Views
{
    public class ProdutosView
    {
        public void ListarTodos(List<Produto>produtos)
        {
            foreach(Produto item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"item.Nome : {item.Nome}");
                Console.WriteLine($"Preço : R$ {item.Preco}");
                

                
                
                
            }
        }
    }
}