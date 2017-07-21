using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Vanirs_Watch.reader
{
    class IniReader
    {
        string Path;

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(
        				string Section,
        				string Key,
        				string Default,
        				StringBuilder RetVal,
        				int Size,
        				string FilePath);

        public IniReader(string IniPath = null)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString("VanirsWatch", Key, "null", RetVal, 255, Path);
            
            if ( RetVal.ToString() == "null" )
            {
            	throw new IOException("No INI file found!");
            }
            return RetVal.ToString();
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}