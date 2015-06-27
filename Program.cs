using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int reqem = 5542;
            string netice = "";

            string[] strteklik = {"Bir ", "İki ", "Üç ", "Dörd ", "Beş ", "Altı ", "Yeddi ", "Səkkiz ", "Doqquz "};
            string[] stronluq = { "On ", "İyirmi ", "Otuz ", "Qırx ", "Əlli ", "Altımış ", "Yetmiş ", "Səksən ", "Doxsan " };
            string[] stryuzluk = {"Yüz "};
            string[] strminlik = {"Min "};
            string[] strmilyon = {"Milyon "};

            string strreqem = reqem.ToString().PadLeft(6,'0');
            string teklik = "", onluq = "", yuzluk = "", tekminlik = "", onminlik = "", yuzminlik = "", tekmilyon = "", onmilyon = "", yuzmilyon = "";


            int son = int.Parse(strreqem.Substring(strreqem.Length-1, 1));
            int ikinci = int.Parse(strreqem.Substring(strreqem.Length-2, 1));


            teklik = strteklik[int.Parse(strreqem.Substring(strreqem.Length - 1, 1))-1];
            onluq = stronluq[int.Parse(strreqem.Substring(strreqem.Length - 2, 1))-1];
            yuzluk = strteklik[int.Parse(strreqem.Substring(strreqem.Length - 3, 1)) - 1] + stryuzluk[0];


            string result = yuzmilyon + onmilyon + tekmilyon + yuzminlik + onminlik + tekminlik + yuzluk + onluq + teklik;



        }
    }
}

