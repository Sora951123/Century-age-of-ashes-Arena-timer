using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Century_timer
{
    internal class Program
    {
        
        static string TellMeGameModeUTC(int time)
        {
            string GameMode = "";
            switch (time % 4)
            {
                case 3:               
                    GameMode = "Survival";
                    break;
                case 0: case 4:
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
        static void Center_text(int heigh, int Width, string text)
        {
            Console.WriteLine(String.Format("{0," + ((heigh / 2) + (Width / 2)) + "}", text));
        }
        static int C_text(int text)
        {
            for (int i = 0; i < text; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return text;
            }
            return 0;
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
            int Width = 5;

            int Res_correction = Width+1;

            Console_Size(heigh, Width);
            Console.CursorVisible=false;

            string Text_1 = "";
            string Text_2 = "";
            string Text_3 = "";


            for (; ;)//Cheat or just dumb?
            {
                Console.WriteLine();
                DateTime Date = DateTime.UtcNow;
                int Hours = Date.Hour;
                int Min = (59 - Date.Minute);
                int sec = (60 - Date.Second);

                //Current arena rotation
                Console.ForegroundColor = ConsoleColor.Blue;
                Text_1 = "\tit's " + TellMeGameModeUTC(Hours).ToUpper();
                Center_text(heigh,Width,Text_1);

                //upcoming Arean rotation
                Console.ForegroundColor = ConsoleColor.Red;
                Text_2 ="\t"+ TellMeGameModeUTC(Hours + 1).ToUpper() + " in " + Min + "." + sec +" min";
                Center_text(heigh,Width,Text_2);

                //3rd Arean rotation
                Console.ForegroundColor = ConsoleColor.Blue;
                Text_3 = "\t"+ TellMeGameModeUTC(Hours+2).ToUpper();     
                Center_text(heigh - Res_correction, Width - Res_correction, Text_3);

                //meamory Debugging
                TrashCollection();
                //Console.WriteLine("Memory usage: {0} bytes", debug_meamory());
                ConsoleStuff(1000,false);
            }
            

        }
    }
}
