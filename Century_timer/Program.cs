using System;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
namespace Century_timer
{

    class CenturyDate
    {
        public ConsoleColor Color;
        public int hours;
        public int min;
        public int sec;
        public int heigh;
        public int Width;
        /*
        public static string TellMeGameModeUTC(int time)
        {
            string GameMode = "";
            switch (time % 4)
            {
                case 3:
                    GameMode = "Survival";
                    break;
                case 0:
                case 4:
                    GameMode = "Skirmish";
                    break;
                case 1:
                    GameMode = "Artifact";
                    break;
                case 2:
                    GameMode = "Gates Of Fire";
                    break;
            }
            return GameMode;
        }
        */
        public static string TellMeGameModeUTC(int time)
        {
            string GameMode = "";
            switch (time % 3)
            {               
                case 0:
                    GameMode = "Skirmish";
                    break;
                case 1:
                    GameMode = "Artifact";
                    break;
                case 2: 
                    GameMode = "Gates Of Fire";
                    break;
            }
            return GameMode;
        }

        public string someting()
        {
            Console.ForegroundColor = Color;
            string text_ = TellMeGameModeUTC(hours+1) + " in " + min + "." + sec + " min";
            return text_;
        }
        public string kek(int n)
        {
            Console.ForegroundColor = Color;
            string text_ = TellMeGameModeUTC(hours + n);
            return text_;
        }

        ~CenturyDate()
        {

        }

    }
    internal class Program
    {

        static void ConsoleStuff(int time, bool Visibility)
        {
            Thread.Sleep(time);
            Console.Clear();
            Console.CursorVisible = Visibility;

        }
        static void Console_Size(int heigh, int width)
        {
            Console.SetWindowSize(heigh, width);
            Console.SetBufferSize(heigh, width);
        }
        static void TrashCollection()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        static long debug_meamory()
        {
            long memoryUsage = GC.GetTotalMemory(true);
            return memoryUsage;
        }




        static void Main(string[] args)
        {


            ///Console.BackgroundColor = ConsoleColor.White;

            int heigh = 35;
            int Width = 4;

                
            int[] array = new int[5];

            array[0] = heigh;
            array[1] = heigh;

            Console_Size(heigh, Width);
            Console.CursorVisible = false;

            

            while (true)//Cheat or just dumb?
            {
                Console.WriteLine();

                DateTime Date = DateTime.UtcNow;

                CenturyDate centuryDate = new CenturyDate();
                
                array[2] = (Date.Hour);
                array[3] = (59 - Date.Minute);
                array[4] = (60 - Date.Second);

                centuryDate.heigh = array[0];
                centuryDate.Width = array[1];
                centuryDate.hours = array[2];
                centuryDate.min = array[3];
                centuryDate.sec = array[4];
                
                centuryDate.Color = ConsoleColor.Red;
                Console.WriteLine("\tIt's "+centuryDate.kek(0));
                centuryDate.Color = ConsoleColor.Blue;
                Console.WriteLine("\t" + centuryDate.someting());
                centuryDate.Color = ConsoleColor.Green;
                Console.WriteLine("\t" + centuryDate.kek(2));
               
                    
 
                //meamory Debugging
                Array.Clear(array, 0, array.Length);
                TrashCollection();
                ConsoleStuff(1000, false);
                /*
                var before = GC.GetTotalMemory(false);
                Console.WriteLine($"Memory used before collection: {before:N0}");
                Console.WriteLine("Memory usage: {0} bytes", debug_meamory());
                */
            }

        }
    }
}
