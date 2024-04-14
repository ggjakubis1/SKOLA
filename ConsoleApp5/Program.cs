using ConsoleApp5;



namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();

            evidence.vytvorZaznam("Walda", "Matuška");
            evidence.vytvorZaznam("Vašek", "Malý");
            evidence.vytvorZaznam("Pavel", "Novák");
            Console.WriteLine("--------VÝPIS--------");
            evidence.vypisZaznamy();
            Console.WriteLine("--------Vyhledávání--------");
            Zamestnanec hledany = evidence.vyheldejPodleID(2);
            Console.WriteLine($"Hledaný zaměstnanec s Id = 2 je \n\t{hledany}");
        }
    }
}
