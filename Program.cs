// Projeto Crição de tabela verdade

using System;
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

    static void Main()
    {
        bool p = LerValor("\nDigite um valor para P (V ou F): ");
        Console.WriteLine($"O valor de P é: {p}");
        bool q = LerValor("\nDigte um valor para Q (V ou F): ");
        Console.WriteLine($"O valor de P é: {q}");

        Console.Write("\nO que deseja verificar? \n1 - Conjunção; \n2 - Disjunção\n \nOpção Escolhida -> ");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine($"P (AND) Q = {Conjunção(p, q)}");
        }

        else if (opcao == 2){
            Console.WriteLine($"P (OR) Q = {Disjunção(p, q)}");
        }

    }
}
