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
            int reqem = 20542;
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


            teklik = int.Parse(strreqem.Substring(strreqem.Length - 1, 1)) >0 ? strteklik[int.Parse(strreqem.Substring(strreqem.Length - 1, 1))-1] : "";
            onluq =  int.Parse(strreqem.Substring(strreqem.Length - 2, 1)) >0  ? stronluq[int.Parse(strreqem.Substring(strreqem.Length - 2, 1))-1] : "";
            yuzluk = int.Parse(strreqem.Substring(strreqem.Length - 3, 1)) >0  ? strteklik[int.Parse(strreqem.Substring(strreqem.Length - 3, 1)) - 1] + "Yüz " : "";



            tekminlik = int.Parse(strreqem.Substring(strreqem.Length - 4, 1)) > 0 ? strteklik[int.Parse(strreqem.Substring(strreqem.Length - 4, 1)) - 1] : "";
            onminlik = int.Parse(strreqem.Substring(strreqem.Length - 5, 1)) > 0 ? stronluq[int.Parse(strreqem.Substring(strreqem.Length - 5, 1)) - 1] : "";
            yuzminlik = int.Parse(strreqem.Substring(strreqem.Length - 6, 1)) > 0 ? strteklik[int.Parse(strreqem.Substring(strreqem.Length - 6, 1)) - 1] + "Yüz " : "";
            string min = int.Parse(strreqem.Substring(0, 3)) > 0 ? "Min " : ""; 

            
            
            string result = yuzminlik + onminlik + tekminlik + min + yuzluk + onluq + teklik;


            Console.WriteLine(result);
        }
    }
}

