using System;

namespace Aula7_Sprint5_Encapsulamento
{
    public class MasterCard : Cartao
    {
         public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto){

            // Utilizando encapsulamento com assinatura "protected"
            cvv = "456";

            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
            
            }
    }
}