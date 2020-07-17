using System.Collections.Generic;
using _34_AplicanoMVC.Models;
using _34_AplicanoMVC.Views;

namespace _34_AplicanoMVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }

    }
}