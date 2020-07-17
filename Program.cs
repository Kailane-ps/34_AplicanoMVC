using System;
using _34_AplicanoMVC.Controllers;
using _34_AplicanoMVC.Views;

namespace _34_AplicanoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("49,98");
        }
    }
}
