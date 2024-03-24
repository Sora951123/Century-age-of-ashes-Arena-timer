using System;
using System.Threading;

namespace Century_timer
{
    public class Functions
    {
        public static void consoleStuff(int time, bool Visibility)
        {
            Thread.Sleep(time);
            Console.Clear();
            Console.CursorVisible = Visibility;

        }
        public static void console_Size(int heigh, int width)
        {
            Console.SetWindowSize(heigh, width);
            Console.SetBufferSize(heigh, width);
        }
        public static void trashCollection()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public static long debug_meamory()
        {
            long memoryUsage = GC.GetTotalMemory(true);
            return memoryUsage;
        }


    }
}
