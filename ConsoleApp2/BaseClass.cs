using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BaseClass
    {
        public static int sayac = 1;
        int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set { }
        }//*
        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool kontrolIslemi = sanalDatabase.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Deyeri sanal db de bulundu siz bu barkodlu mehsulu elave edemezsiniz");
                }
            }
        }//*
        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }
        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;

        }

    }
}
