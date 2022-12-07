using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String>
gyumolcsok = new List<string>() { "alma", "körte", "szilva", "barack", "füge" };

            do
            {
                Console.WriteLine("Kérem az uj gyumolcs nevet: ");
                string ujgyumolcs = Console.ReadLine(); 
                gyumolcsok.Add(ujgyumolcs);

            } while (gyumolcsok.Count()<8);

            string torlendogyumolcs = "";
            
            for (int i = 0; i < gyumolcsok.Count; i++)
            {
                Console.WriteLine("Kérem a törlendő gyumolcsot: ");
                torlendogyumolcs = Console.ReadLine();

                if (torlendogyumolcs != "")
                {
                    if (gyumolcsok[i]==torlendogyumolcs)
                    {
                        gyumolcsok.Remove(torlendogyumolcs);
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < gyumolcsok.Count; i++)
            {
                Console.WriteLine("Kérem az elem indexet: ");
                int indexe = Convert.ToInt32( Console.ReadLine());
                if (gyumolcsok[indexe] == gyumolcsok[i] )
                {
                    gyumolcsok.Add(gyumolcsok[indexe]);
                    gyumolcsok[indexe].Remove(indexe);
                    
                }

                if (indexe > gyumolcsok.Count-1)
                {
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
