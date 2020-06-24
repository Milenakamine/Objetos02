namespace Objetos02
{
    public class Cartao
    {
         public string Titular { get; set; }

          public int Numero { get; set; }
          public string Bandeira { get; set; }
           
          public string Vencimento { get; set; }

        //   private string Cvv; 

     
       public Cartao(string _titular, int _numero, string _bandeira, string _vencimento){
         
         this.Titular = _titular;
         this.Numero = _numero;
         this.Bandeira= _bandeira;
         this.Vencimento= _vencimento;


       }
    }
}