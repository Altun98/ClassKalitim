using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Urun : BaseClass
    {
        public string marka { get; set; }// *
        public string model { get; set; }
        private decimal _alisfiyati;

        public decimal alisFiyati
        {
            get { return _alisfiyati; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("alis fiyati  sifirdan kicik ve ya sifir  olamaz;");
                }
                else
                {
                    _alisfiyati = value;
                }
            }
        }// 0 dan kicik ola bilmez
        private decimal _satisFiyafi;
        public decimal satisFiyati
        {
            get
            { return _satisFiyafi; }
            set
            {
                if (value < alisFiyati)
                {
                    Console.WriteLine("Satis fiyati alis fiyatindan kicik ola bilmez:");
                }
                else
                {
                    _satisFiyafi = value;
                }
            }
        }// satisfiyati alis fiyatindan kicik ola bilmez
        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return _kampanyaFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("kampanya fiyati  sifirdan kicik ve ya sifir  olamaz;");
                }
                else
                {
                    _kampanyaFiyat = value;
                }

            }
        }// 0 dan kicik ola bilmez.

        public void Print()
        {
            Console.WriteLine($"{id},{alisFiyati},{satisFiyati},{model},{marka},{kampanyaFiyat}");
        }
    }
}
