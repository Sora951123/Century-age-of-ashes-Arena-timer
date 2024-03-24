using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Century_timer
{
    class Centurytimer
    {
        private ConsoleColor _color;
        private int _hours;
        private int _min;
        private int _sec;
        private int _height;
        private int _Width;

        public ConsoleColor color { get { return _color; } set { _color = value; } }
        public int hour { get { return _hours; } set { _hours = value; } }
        public int min { get { return _min; } set { _min = value; } }
        public int sec { get { return _sec; } set { _sec = value; } }
        public int height { get { return _height; } set { _height = value; } }
        public int width { get { return _Width; } set { _Width = value; } }

        //time
        public Centurytimer()
        {
            color = ConsoleColor.White;
            hour = 0;
            min = 0;
            sec = 0;
            height = 5;
            width = 28;
        }
        public Centurytimer(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }

        public Centurytimer(int height,int width,int hour, int min, int sec) : this (hour,min,sec)
        {      
            this.height = height;
            this.width = width;
        }


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

        public string someting(int n = 0)
        {
            Console.ForegroundColor = color;
            if (n == 1) {
                return TellMeGameModeUTC(hour + n) + " in " + min + "." + sec + " min";
            }else return TellMeGameModeUTC(hour + n);
        }

    }
}
