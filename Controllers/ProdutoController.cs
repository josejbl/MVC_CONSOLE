using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE.Controllers
{
    public class ProdutoController
    {
        
        Produto produto = new Produto();
        Produto produtoView = new Produto();

        public void MostrarProdutos()
        {
            List<Produto> Todos = produto.ler();
            produtoView.ListarTodos(Todos);
        }

        
        
    }
