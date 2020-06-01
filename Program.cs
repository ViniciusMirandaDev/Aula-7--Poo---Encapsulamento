using System;

namespace Aula7_Sprint5_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Cartao card = new Cartao();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 3;
            //Colocar o f por ser float
            master.ComprarComDescontoMastercard(50f);



        }
    }
}
