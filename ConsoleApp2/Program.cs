using System.Diagnostics.SymbolStore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar b1 = new Bilgisayar();
            b1.marka = "Lenova";
            b1.model = "z250";
            b1.islemci = "i5";
            b1.ram = "16GB";
            b1.alisFiyati = 1520;
            b1.satisFiyati = 1620;
            b1.kampanyaFiyat = b1.alisFiyati;
            b1.barkod = "CD2344545564545";
            sanalDatabase.yeniUrunEkle(b1);

            Bilgisayar b2 = new Bilgisayar();
            b2.marka = "Lenova";
            b2.model = "z250";
            b2.islemci = "i5";
            b2.ram = "16GB";
            b2.alisFiyati = 1520;
            b2.satisFiyati = 1620;
            b2.kampanyaFiyat = b1.alisFiyati;
            b2.barkod = "CD2344545564545";

            sanalDatabase.yeniUrunEkle(b2);

            //}
        }
    }
}
