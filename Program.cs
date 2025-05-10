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
    static void Main()
    {
        bool p = LerValor("Digite V ou F: ");
        Console.WriteLine($"O valor de P é: {p}");
    }
}
