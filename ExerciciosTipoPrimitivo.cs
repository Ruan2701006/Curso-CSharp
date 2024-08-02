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

        public static void Lerarmazenar()
        {
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} {sobrenome}");
        }

        //Peça ao usuário para inserir a idade e exiba o nome e a idade:

        public static void Nomeidade()
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

        public static void nomecidade()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a cidade");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {cidade}");
        }

        //Armazene o nome do usuário em maiúsculas e exiba-o:

        public static void nomeusuariomaiuscula()
        {
            string? nome;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"O nome e: {nome}");
        }

        //Armazene o nome do usuário em minúsculas e exiba-o:

        public static void nomeusuariominuscula ()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a cidade");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {cidade}");
        }

        //Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

        public static void unicalinha()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a cidade");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e {cidade}");
        }
    }
}
