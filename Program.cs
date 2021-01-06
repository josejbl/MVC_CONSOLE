using System;
using MVC_CONSOLE.Controllers;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();

            produtos.Cadastrar();
            
            produtos.MostrarProdutos();
        }
    }
}
