using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanirsWatch.reader
{
    class JobClasses
    {

        private static Dictionary<int, string> jobClasses; = new Dictionary<int, string>();

        static JobClasses()
        {
            // first
            jobClasses.Add(0, "Novice");
            jobClasses.Add(1, "Swordman");
            jobClasses.Add(2, "Mage");
            jobClasses.Add(3, "Archer");
            jobClasses.Add(4, "Acolyte");
            jobClasses.Add(5, "Merchant");
            jobClasses.Add(6, "Thief");

            //2-1
            jobClasses.Add(7, "Knight");
            jobClasses.Add(8, "Priest");
            jobClasses.Add(9, "Wizard");
            jobClasses.Add(10, "Blacksmith");
            jobClasses.Add(11, "Hunter");
            jobClasses.Add(12, "Assassin");

            //2-2
            jobClasses.Add(14, "Crusader");
            jobClasses.Add(15, "Monk");
            jobClasses.Add(16, "Sage");
            jobClasses.Add(17, "Rogue");
            jobClasses.Add(18, "Alchemist");
            jobClasses.Add(19, "Bard");
            jobClasses.Add(20, "Dancer");

            //extended
            jobClasses.Add(23, "Super Novice");
            jobClasses.Add(24, "Gunslinger");
            jobClasses.Add(25, "Ninja");
            jobClasses.Add(4046, "Taekwon");
            jobClasses.Add(4047, "Star Gladiator");
            jobClasses.Add(4049, "Soul Linker");

            //r first
            jobClasses.Add(4001, "High Novice");
            jobClasses.Add(4002, "High Sowrdman");
            jobClasses.Add(4003, "High Mage");
            jobClasses.Add(4004, "High Archer");
            jobClasses.Add(4005, "High Acolyte");
            jobClasses.Add(4006, "High Merchant");
            jobClasses.Add(4007, "High Thief");

            //r 2-1
            jobClasses.Add(4008, "Lord Knight");
            jobClasses.Add(4009, "High Priest");
            jobClasses.Add(4010, "High Wizard");
            jobClasses.Add(4011, "Whitesmith");
            jobClasses.Add(4012, "Sniper");
            jobClasses.Add(4013, "Assassin Cross");

            //r 2-2
            jobClasses.Add(4015, "Paladin");
            jobClasses.Add(4016, "Champion");
            jobClasses.Add(4017, "Professor");
            jobClasses.Add(4018, "Stalker");
            jobClasses.Add(4019, "Creator");
            jobClasses.Add(4020, "Clown");
            jobClasses.Add(4021, "Gypsy");

            //b first
            jobClasses.Add(4023, "Baby Novice");
            jobClasses.Add(4024, "Baby Swordman");
            jobClasses.Add(4025, "Baby Mage");
            jobClasses.Add(4026, "Baby Archer");
            jobClasses.Add(4027, "Baby Acolyte");
            jobClasses.Add(4028, "Baby Merchant");
            jobClasses.Add(4029, "Baby Thief");

            //b 2-1
            jobClasses.Add(4030, "Baby Knight");
            jobClasses.Add(4031, "Baby Priest");
            jobClasses.Add(4032, "Baby Wizard");
            jobClasses.Add(4033, "Baby Blacksmith");
            jobClasses.Add(4034, "Baby Hunter");
            jobClasses.Add(4035, "Baby Assassin");

            //b 2-2
            jobClasses.Add(4037, "Baby Crusader");
            jobClasses.Add(4038, "Baby Monk");
            jobClasses.Add(4039, "Baby Sage");
            jobClasses.Add(4040, "Baby Rogue");
            jobClasses.Add(4041, "Baby Alchemist");
            jobClasses.Add(4042, "Baby Bard");
            jobClasses.Add(4043, "Baby Dancer");

            //b extended
            jobClasses.Add(4045, "Super Baby");
        }

        public string getJobClass(int jobID)
        {
            return jobClasses[jobID];
        }
    }
}
