using System;

namespace Exerc_Programação
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//Exercicio 01---------------------------------------

            double F, C;

            Console.WriteLine("Informe um número para a conversão: ");
            C =Double.Parse(Console.ReadLine());

            F = (C * 9)/5 + 32;

            Console.WriteLine("A temperatura em Fahreint é: " + F);
            //----------------------------------------------------//*/
            /*//Exercicio 02-----------------------------------------

            int salario, valorHora, qtdAula, inss, salarioL;

            Console.WriteLine("Informe o valor da hora:  ");
            valorHora = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas ");
            qtdAula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de % do desconto do Inss: ");
            inss = int.Parse(Console.ReadLine());

            salario = (qtdAula * valorHora);
            inss = (inss /100);
            salarioL = salario - inss;

            Console.WriteLine("O salario liquido é: " + salarioL);
            ----------------------------------------------------------------//*/
            /* //Exercicio 03 ----------------------------------------------

             float resultado, numero;

             Console.WriteLine("Digite um numero: ");
             numero = float.Parse(Console.ReadLine());

             if (numero >= 0)
             {
                 resultado = (float) Math.Sqrt(numero);
                 Console.WriteLine("A raiz quadrada é: " + resultado);
             }
             else
             {
                 resultado = numero * numero;
                 Console.WriteLine("O quadrado é:  " + resultado);
             }
            ---------------------------------------------------------------//*/
            /*//Exercicio 04 -----------------------------------------------------

            double raio, area;

            Console.WriteLine("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());

            area = Math.Pow(raio, 2) * 3.14;

            Console.WriteLine("A area do circulo é: " + area);

            -------------------------------------------------------------//*/
            /*//Exercicio05 -----------------------------------------------

            int anoAtual = DateTime.Now.Year;
            int dataNascimento, id1, id2;

            Console.WriteLine("Informe o ano do nascimento:  ");
            dataNascimento = int.Parse(Console.ReadLine());

            id1 = dataNascimento - anoAtual;
            id2 = 2022 - dataNascimento;

            Console.WriteLine("Idade atual: " + id1);
            Console.WriteLine("Idade em 2022; " + id2);
            ----------------------------------------------------------------//*/
            //Exercicio 06 -----------------------------------------------------
            //












            /*//Exercicio 07 --------------------------------------------------

            int Meta, degrau; 
            double qtdDegrau;

            Console.WriteLine("Informe a altura dos degraus: ");
            degrau = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura que deseja alcançar: ");
            Meta = int.Parse(Console.ReadLine());

            qtdDegrau = Meta / degrau;


            Console.WriteLine("Você deverá subir {0} degraus. ", qtdDegrau);

            -----------------------------------------------------------------//*/
            /*//Exercicio 08 --------------------------------------------------

            double salBruto, SalMin, HorasTrab, ValorHora, SalReceber;
            double imposto;

            Console.Write("Informe o número de horas trabalhadas: ");
            HorasTrab = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do salario minimo: ");
            SalMin = int.Parse(Console.ReadLine());

            HorasTrab = SalMin / 2;
            ValorHora = SalMin / 240;
            salBruto = HorasTrab / ValorHora;
            imposto = salBruto * 0.03;


            SalReceber = salBruto - imposto ;

            Console.WriteLine("O salario que você ira receber é: " + SalReceber);

            ----------------------------------------------------------------------/*/
            /*//Exercicio 09 --------------------------------------------------------

            int numero; 
            
            Console.WriteLine("Informe um número de 0 a 50 para sortearmos seu prêmio!!");
            numero = int.Parse(Console.ReadLine());            
            
                switch (numero)
                {

                    case 5:
                        Console.WriteLine("Parabéns! Você ganhou uma caneta!!");
                        break;
                    case 15:
                        Console.WriteLine("Parabéns! Você ganhou um notebook ");
                        break;
                    case 35:
                        Console.WriteLine("Parabéns! Você ganhou um vale de R$50,00");
                        break;
                    case 48:
                        Console.WriteLine("Parabéns! Você ganhou um PS4");
                        break;

                    default:
                        Console.WriteLine("IIH, Não foi dessa vez!, tente novamente no próximo sorteio.");
                        break;
                
                 }
            -------------------------------------------------------------------------=/*/




































        }
    }

}
