using System.Collections.Generic;

namespace Vanirs_Watch.reader
{
    public static class JobClasses
    {
        private static Dictionary<int, string> jobClasses = new Dictionary<int, string>
        {            
            // first
            {0, "Novice"},
            {1, "Swordman"},
            {2, "Mage"},
            {3, "Archer"},
            {4, "Acolyte"},
            {5, "Merchant"},
            {6, "Thief"},

            //2-1
            {7, "Knight"},
            {8, "Priest"},
            {9, "Wizard"},
            {10, "Blacksmith"},
            {11, "Hunter"},
            {12, "Assassin"},

            //2-2
            {14, "Crusader"},
            {15, "Monk"},
            {16, "Sage"},
            {17, "Rogue"},
            {18, "Alchemist"},
            {19, "Bard"},
            {20, "Dancer"},

            //extended
            {23, "Super Novice"},
            {24, "Gunslinger"},
            {25, "Ninja"},
            {4046, "Taekwon"},
            {4047, "Star Gladiator"},
            {4049, "Soul Linker"},

            //r first
            {4001, "High Novice"},
            {4002, "High Sowrdman"},
            {4003, "High Mage"},
            {4004, "High Archer"},
            {4005, "High Acolyte"},
            {4006, "High Merchant"},
            {4007, "High Thief"},

            //r 2-1
            {4008, "Lord Knight"},
            {4009, "High Priest"},
            {4010, "High Wizard"},
            {4011, "Whitesmith"},
            {4012, "Sniper"},
            {4013, "Assassin Cross"},

            //r 2-2
            {4015, "Paladin"},
            {4016, "Champion"},
            {4017, "Professor"},
            {4018, "Stalker"},
            {4019, "Creator"},
            {4020, "Clown"},
            {4021, "Gypsy"},

            //b first
            {4023, "Baby Novice"},
            {4024, "Baby Swordman"},
            {4025, "Baby Mage"},
            {4026, "Baby Archer"},
            {4027, "Baby Acolyte"},
            {4028, "Baby Merchant"},
            {4029, "Baby Thief"},

            //b 2-1
            {4030, "Baby Knight"},
            {4031, "Baby Priest"},
            {4032, "Baby Wizard"},
            {4033, "Baby Blacksmith"},
            {4034, "Baby Hunter"},
            {4035, "Baby Assassin"},

            //b 2-2
            {4037, "Baby Crusader"},
            {4038, "Baby Monk"},
            {4039, "Baby Sage"},
            {4040, "Baby Rogue"},
            {4041, "Baby Alchemist"},
            {4042, "Baby Bard"},
            {4043, "Baby Dancer"},

            //b extended
            {4045, "Super Baby"}
        };

        public static string getJobClass(int jobID)
        {
            return jobClasses.ContainsKey(jobID) ? jobClasses[jobID] : "Unknown";
        }
    }
}