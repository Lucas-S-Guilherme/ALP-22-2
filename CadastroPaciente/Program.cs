using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPaciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.0 Tipo de variável / Dados - Declaração de variáveis
            // toda variável tem tipo e nome
        
            string nome;
            int idade = 0;
            double peso = 0;
            string cpf;
            string endereco;
            string rg;
            string sexo;

            // 4.0 Entrada - inserção manual dos dados
            nome = "Nome não inserido";
            idade = 34;
            peso = 80;
            cpf = "12312312309";
            endereco = "rua tal e tal";
            rg = "123432";
            sexo = "masculino";

            

            // inserção pelo usuário

            Console.WriteLine("Digite o seu nome"); // escreve na tela
            nome = Console.ReadLine();

            Console.WriteLine("Digite o sua idade");
            idade = int.Parse(Console.ReadLine());

            // variável do tipo int, double precisa que o valor seja convertido, pois o comando Console.WriteLine lê string
            Console.WriteLine("Digite o seu peso");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu CPF"); 
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o seu endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite o seu RG");
            rg = Console.ReadLine();

            Console.WriteLine("Digite o seu Sexo");
            sexo = Console.ReadLine();

            // Mostrar dados digitados
            Console.WriteLine("Esse é o seu Nome: " + nome);
            Console.WriteLine("Esse é a sua Idade: " + idade);
            Console.WriteLine("Esse é a seu Peso: " + peso);
            Console.WriteLine("Esse é a seu CPF: " + cpf);
            Console.WriteLine("Esse é a seu Endereco: " + endereco);
            Console.WriteLine("Esse é a seu RG: " + rg);
            Console.WriteLine("Esse é a seu Sexo: " + sexo);
            Console.ReadKey(); 
            

                       
        }
    }
}
