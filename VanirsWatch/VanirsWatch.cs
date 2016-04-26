using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using VanirsWatch.reader;

namespace VanirsWatch
{
    class VanirsWatch
    {
        private static Reader r = new Reader();
        private static Timer loop = new Timer(1000);
        private static int prevBaseEXP = 0;
        private static int prevJobEXP = 0;

        // needed for exp/h buffer
        private static int tickCounter = 0;
        private static int gainedExpBase = 0;
        private static int gainedExpJob = 0;
        private static int expPerHourBase = 0;
        private static int expPerHourJob = 0;

        static void Main(string[] args)
        {
            //init
            prevBaseEXP = r.getBaseEXP();
            prevJobEXP = r.getJobEXP();

            Timer loop = new Timer(1000);
            loop.Elapsed += loopTick;
            loop.Start();

            while(true)
            {
                //block the program exit
            }


        }

        private static void loopTick(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            int baseEXP = r.getBaseEXP();
            int jobEXP = r.getJobEXP();
            int deltaEXPBase = baseEXP - prevBaseEXP;
            int deltaEXPJob = jobEXP - prevJobEXP;

            gainedExpBase += deltaEXPBase;
            gainedExpJob += deltaEXPJob;
            tickCounter += 1;

            expPerHourBase = (gainedExpBase * 3600) / tickCounter;
            expPerHourJob = (gainedExpJob * 3600) / tickCounter;

            Console.WriteLine( r.getName() + " @ Map: " + r.getMap() );
            Console.WriteLine("Base Lv: " + r.getBaseLv() + " | Job Lv: " + r.getJobLv() + " | " + r.getJob());
            Console.WriteLine("-----");
            Console.WriteLine("BaseEXP: " + baseEXP + "/" + r.getNextBaseEXP() + progressBar(baseEXP, r.getNextBaseEXP()));
            Console.WriteLine(" JobEXP: " + jobEXP + "/" + r.getNextJobEXP() + progressBar(jobEXP, r.getNextJobEXP()));
            Console.WriteLine("BaseEXP/h: " + expPerHourBase +  " | JobEXP/h: " + expPerHourJob);
            Console.WriteLine("-----");
            Console.WriteLine("HP: " + r.getCurrHP() + "/" + r.getMaxHP() + progressBar(r.getCurrHP(), r.getMaxHP()));
            Console.WriteLine("SP: " + r.getCurrSP() + "/" + r.getMaxSP() + progressBar(r.getCurrSP(), r.getMaxSP()));
            Console.WriteLine("-----");
            Console.WriteLine("Weight: " + r.getWeight() + "/" + r.getMaxWeight() + progressBar(r.getWeight(), r.getMaxWeight()));
            Console.WriteLine("Zeny: " + r.getZeny());

            prevBaseEXP = baseEXP;
            prevJobEXP = jobEXP;
        }

        private static String progressBar(int current, int max)
        {
            String bar = " [";
            float currPercent = ((float)current / max) * 50; //50 because we only have max 50 chars for 100% progress bar

            for (int i = 0; i < (int)currPercent; i++)
            {
                bar += "█";
            }
            for (int i = 0; i < (50 - (int)currPercent); i++)
            {
                bar += "_";
            }

            return bar + "]";
        }
    }
}
