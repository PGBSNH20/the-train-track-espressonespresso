using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using TrainEngine;
using System.Threading;
using System.Reflection;
using System.Linq;

namespace TrainConsole
{

    class Program
    {
        public static Clock Clock = new(9, 55);
        static void Main(string[] args)
        {
            Time(); // Start clock

            Console.WriteLine("Train track!");

            var train1 = new TrainPlanner(new Train(2, "Liams tåg", 9000, true)).FollowSchedule().SetSwitch(Switch.Left).ToPlan();
            var train2 = new TrainPlanner(new Train(3, "Kios tåg", 3, true)).FollowSchedule().SetSwitch(Switch.Right).ToPlan();

            var thread = new Thread(() => train1.Start());
            var thread2 = new Thread(() => train2.Start());

            thread.Start();
            thread2.Start();

            Console.WriteLine(train1.TrainInfos[0].hasCrashed);
            //var trainInfos = new TrainInfo();


            //var info = File.ReadAllLines("data/traintrack.txt");
            //var i = 0;

            //var startD = 1;
            //var endD = 2;
            //var gg = new List<int> { 1, 3 };

            //if (gg.Where(g => g == 2).Any())
            //{
            //    Console.WriteLine("Yes");
            //}
            //var distance = 0;
            //foreach (var item in info)
            //{
            //    if (item.Contains('1'))
            //    {
            //        Console.WriteLine(item.Trim(' ').Substring(item.IndexOf(']'), item.IndexOf('<') - item.IndexOf(']')).Length);
            //        Console.WriteLine(item.Trim(' ').Substring(item.IndexOf(']'), item.IndexOf('<') - item.IndexOf(']')));
            //        distance += item.Trim(' ').Substring(item.IndexOf(']'), item.IndexOf('<') - item.IndexOf(']')).Length;
            //    }
            //    else if (item.Contains('2'))
            //    {
            //        Console.WriteLine(item.Trim(' ').Substring(0, item.IndexOf('[') - item.IndexOf('-')).Length);
            //        Console.WriteLine(item.Trim(' ').Substring(0, item.IndexOf('[') - item.IndexOf('-')));
            //        distance += item.Trim(' ').Substring(0, item.IndexOf('[') - item.IndexOf('-')).Length;
            //    }
            //}
            //Console.WriteLine(distance - 1);
        }

        public static async void Time()
        {
            while (true)
            {
                Clock.ClockIsTicking();
                Console.WriteLine(Clock.TimeDisplay());
                await Task.Delay(1000);
            }
        }
    }
}
