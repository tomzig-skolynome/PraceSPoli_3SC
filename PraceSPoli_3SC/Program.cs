namespace PraceSPoli_3SC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zalozit 3 x promennou pro ulozeni cisla
            //pres consoli nacist hodnoty do promennych
            //vytvorit funkci co spocita prumer
            //tu zavolat a zobrazit vysledek do Console

            int cislo1;
            int cislo2;
            int cislo3;

            Console.WriteLine("Zadej cislo 1");
            cislo1 = int.Parse(Console.ReadLine());
            //to same jako si rozdelit na:
            //string text = Console.ReadLine();
            //int.Parse(text);

            Console.WriteLine("Zadej cislo 2");
            cislo2 = int.Parse(Console.ReadLine());

            if ( int.TryParse(Console.ReadLine(), out cislo3) == false)
            {
                Console.WriteLine("Zadana spatna hodnota, nejde o cislo!");
            }

        }



    }
}
