using System;

namespace Aula7_Sprint5_Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string token = "sh7ssdsidhsudhe76u2h3uhhfdhydhyf7sdsadasd7678dsdassad876asd7as6876dasdasd68";
        protected string cvv { get; set; }
        public void AprovarCompra(){
            Console.WriteLine("Compra aprovada!");
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }


    }
}