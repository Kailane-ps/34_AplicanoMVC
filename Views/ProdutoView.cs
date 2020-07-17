using System;
using System.Collections.Generic;
using _34_AplicanoMVC.Models;

namespace _34_AplicanoMVC.Views 
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}