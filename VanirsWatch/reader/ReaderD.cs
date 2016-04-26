using System;
using System.Text.RegularExpressions;

namespace VanirsWatch.reader
{
    public class ReaderD
    {
        //testing statics
        private const String map = "geffen.rsw   rsw";
        private const String name = "Testi MacTestitest";
        private const int maxWeight = 3250;
        private const int maxHP = 1337;
        private const int maxSP = 666;
        private const int baseLv = 42;
        private const int jobLv = 32;
        private const int nextBaseEXP = 100000;
        private const int nextJobEXP = 85000;
        private const int zeny = 123456789;
        private const int jobID = 6;

        private int currWeight = 500;
        private int currBaseEXP = 0;
        private int currJobEXP = 0;
        private int currHP = 1337;
        private int currSP = 666;

        public String getMap()
        {
            //regex: [^\.]+
            return Regex.Match(map, @"^([^\.]*)").Value;
            //return map;
        }

        public String getName()
        {
            return name;
        }

        public int getWeight()
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(0, 100);
            int weightChange = changeNumber(rndNum);

            return currWeight += weightChange;
        }

        public int getMaxWeight()
        {
            return maxWeight;
        }

        public int getCurrHP()
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(0, 10);
            int hpChange = changeNumber(rndNum);

            return currHP += hpChange;
        }

        public int getCurrSP()
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(0, 10);
            int hpChange = changeNumber(rndNum);

            return currSP += hpChange;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public int getMaxSP()
        {
            return maxSP;
        }
        
        public int getBaseLv()
        {
            return baseLv;
        }

        public int getJobLv()
        {
            return jobLv;
        }

        public int getBaseEXP()
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(0, 100);
            return currBaseEXP += rndNum;
        }
        
        public int getJobEXP()
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(0, 85);
            int c = currJobEXP;
            return currJobEXP = c + rndNum;
        }

        public int getNextBaseEXP()
        {
            return nextBaseEXP;
        }

        public int getNextJobEXP()
        {
            return nextJobEXP;
        }

        public int getZeny()
        {
            return zeny;
        }

        public String getJob()
        {
            return JobClasses.getJobClass(jobID);
        }

        private int changeNumber(int rndNum)
        {
            return (rndNum % 2 == 0) ? rndNum : minusRnd(rndNum);
        }

        private int minusRnd(int rndNum)
        {
            return (rndNum - rndNum * 2);
        }
    }
}
