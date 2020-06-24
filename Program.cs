using System;
using System.Collections.Generic;

namespace Objetos02
{
    class Program
    {
        static void Main(string[] args)
        {
            //para criar uma lista :
            List<Produto> produtos= new List<Produto>();

            //cria o produto através do metodo construtor diferente que coloca tudo de uma vez 
            // produtos.Add(new Produto("Moletom Saint Laurent", 1 , 4.315f));
            produtos.Add(new Produto("Vestido Dolce & Gabbana", 2, 9660.00f ));
            produtos.Add(new Produto("Moletom Balmain", 3, 6326.00f));
            produtos.Add(new Produto("Vestido Marchesa Notte", 4, 10819.00f));

            //produto atraves de construtor normal

            // Criamos um produto através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Nome = "Moletom Saint Laurent";
            produto1.Codigo = 1;
            produto1.Preco = 4315.00f;
            produtos.Add(produto1);


            //O construtor foreach fornece uma maneira fácil de iterar sobre arrays.
             foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"{item.Nome}: R$ {item.Preco}.  " );
                Console.ResetColor();
                //muda a cor, o foreground, para o cliente 
            }

            //remover produto como objeto, só dá para remover assim pelo modo construtor padrão 
             produtos.Remove(produto1);

             // Remover item pelo índice
            produtos.RemoveAt(2);

            //eliminar registro
            produtos.RemoveAll(y => y.Nome == "Moletom Saint Laurent");

            //depois de alterada e excluido o registro 
             // Varremos nossa lista depois que foi alterada
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( $"{item.Nome}: R$ {item.Preco}. " );
                Console.ResetColor();
            }

            //achar produto com o y
             Produto moletom = produtos.Find(x => x.Codigo == 3);
             Console.WriteLine("Moletom Balmain: R$"  + moletom.Preco);
            

            //class cartao
            //criando lista cartao
            List<Cartao> cartaoo= new List<Cartao>();

            cartaoo.Add(new Cartao("Milena", 24544444, "Visa", "02/05/2021"));
            cartaoo.Add(new Cartao("Pamela", 55454453, "Mastercard", "24/06/2020"));
            cartaoo.Add(new Cartao("Melissa", 6565654, "American Express", "27/09/2050"));
            cartaoo.Add(new Cartao("Eduardo", 5545454, "Hipercard", "04/10/2090"));


             foreach(Cartao item in cartaoo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine( $"Titular do cartão:{item.Titular}\n Bandeira do cartão:{item.Bandeira}\nData de vencimento do cartão:{item.Vencimento}. " );
                Console.ResetColor();
                //muda a cor, o foreground, para o cliente 
            }

            Carrinho cart = new Carrinho();
            Produto p2 = new Produto("Calça da Disney", 9, 23232325.5f);
            Produto p3 = new Produto("Blusa Zara", 7, 2378596.5f);
            Produto p4 = new Produto("Bolsa da Linha Zara Woman", 8, 444444455.5f);

            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            
            cart.Deletar(p2);


        Produto prodAlterado = new Produto("Vestido Zara",9, 99999999999f);
            cart.Alterar(7, prodAlterado);
        

            cart.Ler();
            cart.MostrarTotal();


        }
    }
}
