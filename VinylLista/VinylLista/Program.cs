using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinyllistan
{
    class Program
    {
        static string[] artist = new string[10];
        static string[] album = new string[10];
        static int[] årtal = new int[10];

        static void Main(string[] args)
        {
            
            artist[0] = "Velvet revolver";
            artist[1] = "Britney spears";
            artist[2] = "Maroon 5";
            album[0] = "Danskebank";
            årtal[0] = 1970;
            album[1] = "tjoho";
            årtal[1] = 1969;
            album[2] = "tudilu";
            årtal[2] = 1980;
            int mainMenuSwitch;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välj alternativ:");
                Console.WriteLine("1. Lägg till");
                Console.WriteLine("2. Ta bort");
                Console.WriteLine("3. Ändra");
                Console.WriteLine("4. Visa lista");
                Console.WriteLine("5. Hejdå");
                mainMenuSwitch = int.Parse(Console.ReadLine());
                switch (mainMenuSwitch)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Remove();
                        break;
                    default:
                        break;
                    case 3:
                        Change();
                        break;
                    case 4:
                        Console.Clear();
                        visaKod();

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }


        }

        private static void visaKod()
        {
            for (int i = 0; i < artist.Length; i++)
            {
                Console.Write(artist[i] + " ");

                Console.Write(album[i] + " ");
                if (årtal[i] != 0)
                {
                    Console.WriteLine(årtal[i] + " ");
                }
            }
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Mata in Artist");
            string artistNamn = Console.ReadLine();
            Console.WriteLine("Mata in Album");
            string albumNamn = Console.ReadLine();
            Console.WriteLine("Mata in årtal");
            int yearName = int.Parse(Console.ReadLine());

            for (int i = 0; i < artist.Length; i++)
            {
                if (artist[i] == null)
                {
                    artist[i] = artistNamn;
                    album[i] = albumNamn;
                    årtal[i] = yearName;
                    i = artist.Length;
                }
            }
        }
        static void Remove()
        {
            Console.WriteLine("Ta bort ALbum");
            string nameToRemove = Console.ReadLine();
            for (int i = 0; i < album.Length; i++)
            {
                if (album[i] == nameToRemove)
                {
                    artist[i] = null;
                    album[i] = null;

                    årtal[i] = 0;
                }
               

            }
        }
        static void Change()
        {
        
            Console.WriteLine("Vilket album vill du ändra på? ");
           string albumToEdit = Console.ReadLine();
            Console.WriteLine("Ändra Album");
            string albumNamn = Console.ReadLine();
            Console.WriteLine("Ändra Artist");
            string artistNamn = Console.ReadLine();
            Console.WriteLine("Ändra årtal");
            int yearName = int.Parse(Console.ReadLine());
            for (int i = 0; i < album.Length; i++)
            {
                if (album[i] == albumToEdit)
                {
                    artist[i] = artistNamn;
                    album[i] = albumNamn;
                    årtal[i] = yearName;

                }
            }
        }


    }
}
