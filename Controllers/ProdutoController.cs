using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;
using MVC_CONSOLE.Views;

namespace MVC_CONSOLE.Controllers
{
    public class ProdutoController
    {
        
        Produto produto = new Produto();
        ProdutosView produtoView = new ProdutosView();



        public void MostrarProdutos()
        {
            List<Produto> Todos = produto.Ler();
            produtoView.ListarTodos(Todos);
        }
        public void Cadastrar()
        {
            produto.Inserir(produtoView.CadastrarProduto( ) );
        }

        
        
    }
}