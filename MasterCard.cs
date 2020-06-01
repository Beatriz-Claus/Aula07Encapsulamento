using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {
        

        public int parcelas { get; set;} 

        public void ComprarComDescontoMastercard(float desconto) {

            //Ultilizando encapsulamento com assinatura "Protected"
            cvv = "456" ;


            Console.WriteLine($"Compra ralizada com {parcelas} e R$ {desconto} de desconto" );
        }
    }
}