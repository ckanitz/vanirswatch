using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VanirsWatch
{
    class VanirsWatch
    {
        const int PROCESS_WM_READ = 0x0010;
        const int INTBUFFER_SIZE = 4;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
        int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        static void Main(string[] args)
        {

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
    }
}
