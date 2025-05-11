// Projeto Crição de tabela verdade

using System;
using System.Reflection.Metadata;
class Program
{

    static bool LerValor(string mensagem)
    {
        char entrada;

        do
        {
            Console.Write(mensagem);
            entrada = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (entrada != 'V' && entrada != 'F');

        return entrada == 'V';
    }

    static bool Conjunção(bool p, bool q)
    {
        return p && q;
    }

    static bool Disjunção(bool p, bool q)
    {
        return p || q;
    }

    static bool Negação(bool valor)
    {
        return !valor;
    }

    static bool Bicondicional(bool p, bool q)
    {
        return p == q;
    }

    static bool Implicação(bool p, bool q)
    {
        return !p || q;
    }

    static void Main()
    {
        bool p = LerValor("\nDigite um valor para P (V ou F): ");
        Console.WriteLine($"O valor de P é: {p}");
        bool q = LerValor("\nDigte um valor para Q (V ou F): ");
        Console.WriteLine($"O valor de P é: {q}");

        Console.Write("\nO que deseja verificar? \n1 - Conjunção \n2 - Disjunção\n3 - Negação\n4 - Bicondicional\n5 - Implicação Lógica\n  \nOpção Escolhida -> ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine($"P (AND) Q = {Conjunção(p, q)}");
                break;

            case 2:
                Console.WriteLine($"P (OR) Q = {Disjunção(p, q)}");
                break;

            case 3:
                Console.WriteLine($"~P = {Negação(p)}");
                Console.WriteLine($"~Q = {Negação(q)}");
                break;

            case 4:
                Console.WriteLine($"P <--> Q = {Bicondicional(p, q)}");
                break;

            case 5:
                Console.WriteLine($"P -> Q = {Implicação(p, q)}");
                break;

            case 6:
                Console.WriteLine($"Tabela completa: ");
                
                break;

            default:
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 4.");
                break;
        }

    }
}
