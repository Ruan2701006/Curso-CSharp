using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_
{
    public class ExerciciosTipoPrimitivo
    {
        //Modifique o método LerArmazenar para armazenar o sobrenome do usuário e
        //exibi-lo junto com o nome:

        /*public static void LerArmazenar()
        {
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {sobrenome}");
        }

        //Peça ao usuário para inserir a idade e exiba o nome e a idade:

        public static void NomeIdade()
        {
            string? idade;
            string? nome;
            Console.WriteLine("Digite a sua idade:");
            idade = Console.ReadLine();
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine($"A idade e: {idade} e {nome}");

        }

        //Peça ao usuário para inserir a cidade e exiba o nome e a cidade:

        public static void NomeCidade()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {cidade}");
        }

        //Armazene o nome do usuário em maiúsculas e exiba-o:

        public static void NomeusuarioMaiuscula()
        {
            string? nome;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine().ToUpper();
            Console.WriteLine($"O nome e: {nome}");
        }

        //Armazene o nome do usuário em minúsculas e exiba-o:

        public static void NomeusuarioMinuscula()
        {
            string? nome;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine().ToLower();
            Console.WriteLine($"O nome e: {nome}");

        }*/

        //Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

        public static void UnicaLinha()
        {
            string? nome;
            string? idade;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            nome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {idade}");
        }
    }
}
