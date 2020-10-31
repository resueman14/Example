using System;
using System.Timers;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace Example
{
    class Program
    {
        static Timer aTimer;
        static SoundPlayer snd = new SoundPlayer(Properties.Resources._1);
        static void Main(string[] args)
        {
            try
            {
                int mins = Convert.ToInt32(args[0]);
                Console.WriteLine("Period "+mins+" mins ");
                aTimer = new System.Timers.Timer();
                aTimer.Interval = mins * 60000;
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;

                Console.WriteLine("Press the Enter key to exit the program at any time... ");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Help();
                Console.WriteLine(e.Message);
            }
        }

        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
                snd.Play();
        }

        static void Help()
        {
            Console.WriteLine("Usage: 1st argument time in minutes ...");
        }
    }
}
