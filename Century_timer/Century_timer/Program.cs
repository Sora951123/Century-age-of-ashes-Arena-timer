using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using System.Timers;
namespace Century_timer
{

    
    internal class Program
    {

        static void Main(string[] args)
        {


            ///Console.BackgroundColor = ConsoleColor.White;

            int heigh = 35; // 35
            int Width = 5; // 5

            int[] array = new int[5];
            
            array[0] = heigh;
            array[1] = heigh;

            Functions.console_Size(heigh, Width);
            Console.CursorVisible = false;

            while (true)//Cheat or just dumb?
            {
                Console.WriteLine();

                DateTime Date = DateTime.UtcNow;

                Centurytimer centuryDate = new Centurytimer();
                
                array[2] = (Date.Hour);
                array[3] = (59 - Date.Minute);
                array[4] = (60 - Date.Second);

                centuryDate.height = array[0];
                centuryDate.width = array[1];
                centuryDate.hour = array[2];
                centuryDate.min = array[3];
                centuryDate.sec = array[4];

                List<ConsoleColor> list = new List<ConsoleColor>();
                list.Add(ConsoleColor.Red);
                list.Add(ConsoleColor.Blue);
                list.Add(ConsoleColor.Green);

                List<string> STR = new List<string>();
                STR.Add("\tIt's ");
                STR.Add("\t");
                STR.Add("\t");
                
                for (int i = 0; i < list.Count; i++) {
                    centuryDate.color = list[i];
                    Console.WriteLine(STR[i] + centuryDate.someting(i));
                }
                
                //meamory Debugging
                Array.Clear(array, 0, array.Length);
                Functions.trashCollection();
                Functions.consoleStuff(1000, false);
                /*
                var before = GC.GetTotalMemory(false);
                Console.WriteLine($"Memory used before collection: {before:N0}");
                Console.WriteLine("Memory usage: {0} bytes", debug_meamory());
                */
            }

        }
    }
}
