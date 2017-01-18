using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeZadanie
{
    

    public class DateTimePrzyklad
    {
        public static void Main()
        {
            DateTime data;
            string formatWejscowy = "dd-MM-yyyy HH:mm:ss";
            Console.WriteLine("Podaj datę w formacie {0}:", formatWejscowy);
            while (true)
            {
                try
                {
                    data = DateTime.ParseExact(Console.ReadLine(), formatWejscowy, null);
                    break;
                }
                catch
                {
                    Console.WriteLine("Podano nieprawidłową datę:");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Dzień miesiąca: {0}", data.Day.ToString("D2"));
            Console.WriteLine("Numer miesiąca: {0}", data.Month.ToString("D2"));
            Console.WriteLine("Rok: {0}", data.Year);
            Console.WriteLine("Godzina: {0}", data.Hour);
            Console.WriteLine("Minuty: {0}", data.Minute);
            Console.WriteLine("Sekundy: {0}", data.Second);

            Console.ReadKey();
        }
    }
    }
