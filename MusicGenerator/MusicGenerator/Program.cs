using System;
namespace app {
    class Program {
        static void Main(){
            Console.Write("Počateční frekvence: ");
            int pocatecniFrekvence = int.Parse(Console.ReadLine());
            Console.Write("Konečná frekvence: ");
            int konecnaFrekvence = int.Parse(Console.ReadLine());
            Console.Write("Krok: ");
            int krok = int.Parse(Console.ReadLine());
            Console.Write("Čas: ");
            int cas = int.Parse(Console.ReadLine());
            for(int i = pocatecniFrekvence; i<=konecnaFrekvence; i+=krok)
            {   
                Console.WriteLine(i);
                Console.Beep(i,cas);
            }
        }
    }
}