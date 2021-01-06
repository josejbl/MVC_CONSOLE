using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE.Views
{
    public class ProdutosView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach(Produto item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"item.Nome : {item.Nome}");
                Console.WriteLine($"Preço : R$ {item.Preco}");
            }
        }
        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o código do Produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Nome do Produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do Produto:");
            produto.Preco = float.Parse(Console.ReadLine());
            
            
            return produto;
        }
    }
}