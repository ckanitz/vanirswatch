using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using VanirsWatch.reader;

namespace VanirsWatch
{
    class VanirsWatch
    {
        //const int PROCESS_WM_READ = 0x0010;
        //const int INTBUFFER_SIZE = 4;
        //const int HOURMS = 360000;
        private static Reader r = new Reader();
        private static Timer loop = new Timer(1000);
        //private static int prevTime = 0;
        private static int prevBaseEXP = 0;
        private static int prevJobEXP = 0;

        /*[DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
        int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        */
        static void Main(string[] args)
        {
            //Timer loop = new Timer(1000);
            loop.Elapsed += loopTick;
            loop.Start();

            while(true)
            {
                //block the program exit
            }


            /** let's make a debug class first!
              * implement that stuff later again ;)


            Process process = Process.GetProcessesByName("my")[0];
            Console.WriteLine(process.ProcessName);
            IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

            int bytesRead = 0;
            byte[] buffer = new byte[24]; //'Hello World!' takes 12*2 bytes because of Unicode 

            
            // map          008E8988
            ReadProcessMemory((int)processHandle, 0x008E8988, buffer, buffer.Length, ref bytesRead);
            Console.WriteLine("Map: " + System.Text.Encoding.Default.GetString(buffer));
            
            //weight:       009A51E0
            ReadProcessMemory((int)processHandle, 0x009A51E0, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("Weight: " + bufferToInt(buffer));

            //maxWeight:    009A51D4
            ReadProcessMemory((int)processHandle, 0x009A51D4, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("MaxWeight: " + bufferToInt(buffer));

            //HP: 		    009A75A8
            ReadProcessMemory((int)processHandle, 0x009A75A8, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("HP: " + bufferToInt(buffer));

            //SP: 		    009A75B0
            ReadProcessMemory((int)processHandle, 0x009A75B0, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("SP: " + bufferToInt(buffer));

            //base - EXP:	009A5120
            ReadProcessMemory((int)processHandle, 0x009A5120, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("BaseEXP: " + bufferToInt(buffer));

            //job - EXP:	009A51DC
            ReadProcessMemory((int)processHandle, 0x009A51DC, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("JobEXP: " + bufferToInt(buffer));

            //nextBase:	    009A512C
            ReadProcessMemory((int)processHandle, 0x009A512C, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("nextBase: " + bufferToInt(buffer));

            //nextJob:	    009A51D8
            ReadProcessMemory((int)processHandle, 0x009A51D8, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("nextJob: " + bufferToInt(buffer));

            //Zeny:		    009A51C8
            ReadProcessMemory((int)processHandle, 0x009A51C8, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("Zeny: " + bufferToInt(buffer));

            //Name:		    009A7DC0
            ReadProcessMemory((int)processHandle, 0x009A7DC0, buffer, buffer.Length, ref bytesRead);
            Console.WriteLine("Name: " + System.Text.Encoding.Default.GetString(buffer));

            //Job:		    009A511C   -> ID! not the jobname itself!
            ReadProcessMemory((int)processHandle, 0x009A511C, buffer, INTBUFFER_SIZE, ref bytesRead);
            Console.WriteLine("JobID: " + bufferToInt(buffer));

            */
        }

        private static void loopTick(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            int baseEXP = r.getBaseEXP();
            int jobEXP = r.getJobEXP();

            Console.WriteLine( r.getName() + " @ Map: " + r.getMap() );
            Console.WriteLine("Base Lv: " + r.getBaseLv() + " | Job Lv: " + r.getJobLv() + " | " + r.getJob());
            Console.WriteLine("-----");
            Console.WriteLine("BaseEXP: " + baseEXP + "/" + r.getNextBaseEXP() + progressBar(baseEXP, r.getNextBaseEXP()));
            Console.WriteLine(" JobEXP: " + jobEXP + "/" + r.getNextJobEXP() + progressBar(jobEXP, r.getNextJobEXP()));
            Console.WriteLine("BaseEXP/h: " + (baseEXP - prevBaseEXP) * 360 +  " | JobEXP/h: " + (jobEXP - prevJobEXP) * 360);
            Console.WriteLine("-----");
            Console.WriteLine("HP: " + r.getCurrHP() + "/" + r.getMaxHP() + progressBar(r.getCurrHP(), r.getMaxHP()));
            Console.WriteLine("SP: " + r.getCurrSP() + "/" + r.getMaxSP() + progressBar(r.getCurrSP(), r.getMaxSP()));
            Console.WriteLine("-----");
            Console.WriteLine("Weight: " + r.getWeight() + "/" + r.getMaxWeight() + progressBar(r.getWeight(), r.getMaxWeight()));
            Console.WriteLine("Zeny: " + r.getZeny());

            prevBaseEXP = baseEXP;
            prevJobEXP = jobEXP;
            /*
            name @ map
            Base Job Class
            -----
            BaseEXP: currExp / nextBase
            JobEXP: currExp / nextJob
            -----
            HP: currHP / maxHP
            SP: currSP / maxSP
            -----
            Weight: currWeigt / maxWeight
            Zeny: zeny
            */

            /*
            String bar = "[";
            for(int i = 0; i < 25; i++)
            {
                bar += "█";
            }
            for(int i = 0; i < 25; i++)
            {
                bar += "_";
            }
            Console.WriteLine("Count" + count++);
            Console.WriteLine("BaseEXP: " + bar + "]");
            */
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
        /*
        private static int bufferToInt(byte[] buffer)
        {
            int valueClc = 0;
            for (int i = INTBUFFER_SIZE - 1; i >= 0; i--)
            {
                valueClc *= 256;
                valueClc += (int)buffer[i];
            }

            return valueClc;
        }
        */
    }
}
