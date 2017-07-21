/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 21.07.2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Vanirs_Watch.reader;

namespace Vanirs_Watch
{
	/// <summary>
	/// Description of View.
	/// </summary>
	partial class MainForm
	{
		private const int INTERVAL = 1000;
		private static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		private static int tickCounter;
		
		private static Reader r;
		
		private static int baseEXP;
        private static int jobEXP;
		private static int prevBaseEXP;
        private static int prevJobEXP;
        private static int baseLevel;
        private static int jobLevel;

        // needed for exp/h buffer
        private static int gainedExpBase;
        private static int gainedExpJob;
        private static int expPerHourBase;
        private static int expPerHourJob;

        public void InitializeUpdate()
        {
        	// init variables
			tickCounter = 0;
			prevBaseEXP = 0;
	        prevJobEXP = 0;
	        gainedExpBase = 0;
	        gainedExpJob = 0;
	        expPerHourBase = 0;
	        expPerHourJob = 0;
	        baseLevel = 0;
	        jobLevel = 0;
	        
	        // init reader
			try {
				r = new Reader();
				this.InitLabels(); // run once to get init values
			} catch( Exception ex ) {
				throw new Exception( ex.Message );
			}
       	
        	// start timer stuff
			myTimer.Tick += new EventHandler(TimerEventProcessor);
			myTimer.Interval = INTERVAL;
        }
        
        void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			tickCounter++;
			baseEXP = r.getBaseEXP();
            jobEXP = r.getJobEXP();
      
            int deltaEXPBase = baseEXP - prevBaseEXP;
            int deltaEXPJob = jobEXP - prevJobEXP;

            gainedExpBase += deltaEXPBase;
            gainedExpJob += deltaEXPJob;
            tickCounter += 1;

            expPerHourBase = (int)Math.Round((double) (gainedExpBase / tickCounter) * 3600 );
            expPerHourJob = (int)Math.Round((double) (gainedExpJob / tickCounter) * 3600 );

            prevBaseEXP = baseEXP;
            prevJobEXP = jobEXP;
            
            this.UpdateForm();
		}
        
        public void InitLabels()
        {
        	// we need to write constant labels just once
        	this.lbl_charname.Text = r.getName();
        	this.lbl_class.Text = r.getJob();
        	
        	baseLevel = r.getBaseLv();
        	jobLevel = r.getJobLv();
        	
        	this.UpdateForm();
        }
        
		public void UpdateForm()
		{
			// just experimental if this reduces forms flickering... maybe remove it later
			if ( baseLevel == 0 && baseLevel != r.getBaseLv() ) {
				baseLevel = r.getBaseLv();
				this.lbl_blvl.Text = baseLevel.ToString();
			}
			if ( jobLevel == 0 && jobLevel != r.getJobLv() ) {
				jobLevel = r.getJobLv();
				this.lbl_jlvl.Text = jobLevel.ToString();
			}
        	        
			// HP Stuff			
			int hpCur = r.getCurrHP();
			int hpMax = r.getMaxHP();
			int hpPer = (int)this.percentage(hpCur, hpMax, 0);
			// z% x/y
			this.lbl_hp_current.Text = hpPer.ToString() + "% " + hpCur.ToString() + "/" + hpMax.ToString();
			this.hp_bar.Width = hpPer;
			
			// SP Stuff
			int spCur = r.getCurrSP();
			int spMax = r.getMaxSP();
			int spPer = (int)this.percentage(spCur, spMax, 0);
			// z% x/y
			this.lbl_sp_current.Text = spPer.ToString() + "% " + spCur.ToString() + "/" + spMax.ToString();
			this.sp_bar.Width = spPer;
			
			// Base EXP Stuff
			int nextBase = r.getNextBaseEXP();
			double percBase = this.percentage(baseEXP, nextBase, 1);
			this.lbl_bexp_current.Text = percBase.ToString() + "%";
			this.base_bar.Width = (int)percBase;
			
			// Job EXP Stuff
			int nextJob = r.getNextJobEXP();
			double percJob = this.percentage(jobEXP, nextJob, 1);
			this.lbl_jexp_current.Text = percJob.ToString() + "%";
			this.job_bar.Width = (int)percJob;
			
			// EXP per hour
			this.lbl_bexp_hour.Text = expPerHourBase + " EXP/h";
			this.lbl_jexp_hour.Text = expPerHourJob + " EXP/h";
			
			// Misc
			this.lbl_zeny_current.Text = r.getZeny().ToString();
			this.lbl_weight_current.Text = r.getWeight().ToString();
		}
		
		private double percentage(int cur, int max, int decimals)
		{
			double value = 0;
			
			if ( decimals == 0) {
				value = Math.Round((double)(100 * cur) / max);
			} else {
				value = Math.Round((double)(100 * cur) / max, decimals);
			}
			
			return value;
		}
	}
}
