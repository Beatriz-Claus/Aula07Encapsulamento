using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set;}

        public string titular { get; set;}

        public string bandeira { get; set;}

        private string  token = "f3i4j3fh03fh4fu3rurjd0pu2rh3j498fh38o49hfu84yf3894";

        protected string cvv { get; set;}


        public void AprovarCompra(){
            System.Console.WriteLine("Compra Aprovada!");
        }

        private bool ValidarToken(){
            if (token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}