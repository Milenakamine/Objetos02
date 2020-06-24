using System;
using System.Collections.Generic;

namespace Objetos02
{
    public class Carrinho
    {
        public float ValorT { get; set; }

// carrinho agrupa os dados de produto
        List<Produto> carrinho = new List<Produto>();

//passar como inteiro e não separado com o this
        public void Adicionar(Produto _prod){
          carrinho.Add(_prod);
        }

        public void Deletar(Produto _delete){
            carrinho.Remove(_delete);
        }
//oq vai aparecer para o cliente quando se aplica no program
        public void Ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"{item.Nome}: R${item.Preco}.");
            }
        }


        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(z => z.Codigo == _cod).Nome  = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }


      public void MostrarTotal(){
          foreach(Produto item in carrinho){
          ValorT += item.Preco;
       }
        Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine($"O valor total de sua compra é: R${ValorT}");
         Console.ResetColor();
    }


    }
}