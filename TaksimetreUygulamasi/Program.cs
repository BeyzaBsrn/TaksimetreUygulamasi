namespace Odev._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acilisUcreti = 150;
            int kmBasiUcret = 25;
            double geceTarifesiOrani = 1.2;
            Console.WriteLine("gidilen mesafe kaç km'dir ?");
            int km = Convert.ToInt32(Console.ReadLine());
            if (km < 0)
            {
                Console.WriteLine("Hata,mesafe 0'dan küçük olmamalı.");
            }
            Console.WriteLine("GECE TARİFESİ Mİ ?(EVET/HAYIR):");
            string geceTarifesiMi = Console.ReadLine().Trim().ToLower();

            bool geceTarifesi = geceTarifesiMi == "evet";

            double toplamUcret = acilisUcreti + (km * kmBasiUcret);

            if (geceTarifesi)
            {
                toplamUcret *= geceTarifesiOrani;
            }
            Console.WriteLine($"toplam ücret: {toplamUcret} TL");


        }
    }
}
