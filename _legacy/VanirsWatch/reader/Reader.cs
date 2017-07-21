using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace VanirsWatch.reader
{
    class Reader
    {
        private const int PROCESS_WM_READ = 0x0010; //"read"-token
        private const int INTBUFFER_SIZE = 4; //max byte length´, 4 is enough for everything with int as return value
        private String proccessName;
        private IniReader ini = new IniReader("VanirsWatch.ini");

        // addresses
        private int mapAddr;
        private int nameAddr;
        private int hpAddr;
        private int spAddr;
        private int maxHPAddr;
        private int maxSPAddr;
        private int baseLvAddr;
        private int jobLvAddr;
        private int baseExpAddr;
        private int jobExpAddr;
        private int nextLvExpBaseAddr;
        private int nextLvExpJobAddr;
        private int weightAddr;
        private int maxWeightAddr;
        private int zenyAddr;
        private int jobIDAddr;
        /*
        private const int mapAddr           = 0x008E8988;
        private const int nameAddr          = 0x009A7DC0;
        private const int hpAddr            = 0x009A75A8;
        private const int spAddr            = 0x009A75B0;
        private const int maxHPAddr         = 0x009A75AC;
        private const int maxSPAddr         = 0x009A75B4;
        private const int baseLvAddr        = 0x009A5124;
        private const int jobLvAddr         = 0x009A5130;
        private const int baseExpAddr       = 0x009A5120;
        private const int jobExpAddr        = 0x009A51DC;
        private const int nextLvExpBaseAddr = 0x009A512C;
        private const int nextLvExpJobAddr  = 0x009A51D8;
        private const int weightAddr        = 0x009A51E0;
        private const int maxWeightAddr     = 0x009A51D4;
        private const int zenyAddr          = 0x009A51C8;
        private const int jobIDAddr         = 0x009A511C;
        */

        private Process process;
        private IntPtr processHandle;
        private int bytesRead;
        private byte[] buffer;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
        int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        //constructor
        public Reader() {
            proccessName = ini.Read("Ragexe");

            mapAddr = Convert.ToInt32(ini.Read("mapAddr").Substring(2), 16);
            nameAddr = Convert.ToInt32(ini.Read("nameAddr").Substring(2), 16);
            hpAddr = Convert.ToInt32(ini.Read("hpAddr").Substring(2), 16);
            spAddr = Convert.ToInt32(ini.Read("spAddr").Substring(2), 16);
            maxHPAddr = Convert.ToInt32(ini.Read("maxHPAddr").Substring(2), 16);
            maxSPAddr = Convert.ToInt32(ini.Read("maxSPAddr").Substring(2), 16);
            baseLvAddr = Convert.ToInt32(ini.Read("baseLvAddr").Substring(2), 16);
            jobLvAddr = Convert.ToInt32(ini.Read("jobLvAddr").Substring(2), 16);
            baseExpAddr = Convert.ToInt32(ini.Read("baseExpAddr").Substring(2), 16);
            jobExpAddr = Convert.ToInt32(ini.Read("jobExpAddr").Substring(2), 16);
            nextLvExpBaseAddr = Convert.ToInt32(ini.Read("nextLvExpBaseAddr").Substring(2), 16);
            nextLvExpJobAddr = Convert.ToInt32(ini.Read("nextLvExpJobAddr").Substring(2), 16);
            weightAddr = Convert.ToInt32(ini.Read("weightAddr").Substring(2), 16);
            maxWeightAddr = Convert.ToInt32(ini.Read("maxWeightAddr").Substring(2), 16);
            zenyAddr = Convert.ToInt32(ini.Read("zenyAddr").Substring(2), 16);
            jobIDAddr = Convert.ToInt32(ini.Read("jobIDAddr").Substring(2), 16);

            process = Process.GetProcessesByName(proccessName)[0];
            processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

            bytesRead = 0;
            buffer = new byte[24]; //big enough for everything, just in case
        }

        public String getMap()
        {
            ReadProcessMemory((int)processHandle, mapAddr, buffer, buffer.Length, ref bytesRead);
            
            //return System.Text.Encoding.Default.GetString(buffer); <-- old stuff, may delete later after testing :)
            return Regex.Match(System.Text.Encoding.Default.GetString(buffer), @"^([^\.]*)").Value;
        }

        public String getName()
        {
            ReadProcessMemory((int)processHandle, nameAddr, buffer, buffer.Length, ref bytesRead);
            return System.Text.Encoding.Default.GetString(buffer);
        }

        public int getWeight()
        {
            ReadProcessMemory((int)processHandle, weightAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getMaxWeight()
        {
            ReadProcessMemory((int)processHandle, maxWeightAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getCurrHP()
        {
            ReadProcessMemory((int)processHandle, hpAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getCurrSP()
        {
            ReadProcessMemory((int)processHandle, spAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getMaxHP()
        {
            ReadProcessMemory((int)processHandle, maxHPAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getMaxSP()
        {
            ReadProcessMemory((int)processHandle, maxSPAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getBaseLv()
        {
            ReadProcessMemory((int)processHandle, baseLvAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getJobLv()
        {
            ReadProcessMemory((int)processHandle, jobLvAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getBaseEXP()
        {
            ReadProcessMemory((int)processHandle, baseExpAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getJobEXP()
        {
            ReadProcessMemory((int)processHandle, jobExpAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getNextBaseEXP()
        {
            ReadProcessMemory((int)processHandle, nextLvExpBaseAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getNextJobEXP()
        {
            ReadProcessMemory((int)processHandle, nextLvExpJobAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public int getZeny()
        {
            ReadProcessMemory((int)processHandle, zenyAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return bufferToInt(buffer);
        }

        public String getJob()
        {
            ReadProcessMemory((int)processHandle, jobIDAddr, buffer, INTBUFFER_SIZE, ref bytesRead);
            return JobClasses.getJobClass(bufferToInt(buffer));
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
