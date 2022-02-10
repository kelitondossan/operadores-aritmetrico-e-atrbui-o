using System;

namespace EXEMPLOS
{
    class Program
    {
        static void Main(string[] args)
        { 
            //OPERADORES DE ATRIBUIÇÃO
            
            //int A = 10;
            //Console.WriteLine(A);//AQUI ELE DEVE MOSTRA 30 QUANDO EXECUTADO

          //  A += 2;
            //Console.WriteLine(A);// AQUI USANDO OPERADO DE ATRIBUIÇÃO ELE DEVE MOSTRAR NA TELA 32 A SOAM DA PRIMEIRA VARIAVL QUE DEU 30 MAIS A SEGUNDA VARIAVEL COM O OPERADOR DE ATRIBUIÇÃO 

          //  A *= 3;
            //Console.WriteLine(A);
            // 
            //FUNCIONA TAMBEMCOM VARIAVEIS STRNG EXEMPLO A BAIXO 

          //  string S = "ABC";
            //Console.WriteLine(S);

            //S +="DEF";
           // Console.WriteLine(A);

            //OPERADORES DE ATYRIBUIÇÃO

            int a = 10;
            int b= a++;
            Console.WriteLine($"{a}\n{b}");

            int d = 10;
            int f = ++d;
            Console.WriteLine($"{d}\n{f}");

            int g= 10;
            int h = d--;
            Console.WriteLine($"{g}\n{h}");

            int j = 10;
            int k = --j;
            Console.WriteLine($"{j}\n{k}");
         









        }
    }
}
