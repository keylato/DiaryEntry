using System;
using System.Collections;
using System.IO;
using System.Globalization;

namespace DairyEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime hoy = DateTime.Now;
            CultureInfo culture = new CultureInfo("es-Mx");
            string hoyAsStr = hoy.ToString(culture);
            string nombreDocumento = hoyAsStr.Replace("/","=");

            Console.WriteLine("Entas entrando a tu Diario");
            string bienvenida = Console.ReadLine();
            Console.WriteLine("guardando la fecha de hoy" + hoyAsStr);

            using(StreamWriter sw = new StreamWriter(nombreDocumento+".txt"))
            {
                sw.WriteLine(bienvenida);
            }



        }
    }
}
