using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuário, o que você pensa sobre mim?");
            string fala = Console.ReadLine();
            fala = fala.Remove (10);
            Console.WriteLine(fala + "... NÃO, PERA. Tô nervoso.");

            
        }
    }
}
