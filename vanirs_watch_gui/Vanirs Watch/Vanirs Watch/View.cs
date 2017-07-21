/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 21.07.2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Vanirs_Watch
{
	/// <summary>
	/// Description of View.
	/// </summary>
	public class View
	{        
		public View()
		{
			this.updateForm();
		}
		
		public void updateForm()
		{
			
			int hpCur = r.getCurrHP();
			int hpMax = r.getMaxHP();
			int hpPer = (int)this.percentage(hpCur, hpMax, 0);
			// z% x/y
			form.lbl_hp_current.Text = hpPer.ToString() + "% " + hpCur.ToString() + "/" + hpMax.ToString();
			form.hp_bar.Width = hpPer;
			
			int spCur = r.getCurrSP();
			int spMax = r.getMaxSP();
			int spPer = (int)this.percentage(spCur, spMax, 0);
			// z% x/y
			form.lbl_sp_current.Text = spPer.ToString() + "% " + spCur.ToString() + "/" + spMax.ToString();
			form.sp_bar.Width = spPer;
			
			int nextBase = r.getNextBaseEXP();
			double percBase = this.percentage(baseEXP, nextBase, 1);
			form.lbl_bexp_current.Text = percBase.ToString() + "%";
			form.base_bar.Width = (int)percBase;
			
			int nextJob = r.getNextJobEXP();
			double percJob = this.percentage(jobEXP, nextJob);
			form.lbl_jexp_current.Text = percJob.ToString() + "%";
			form.job_bar.Width = (int)percJob;
			
			form.lbl_bexp_hour.Text = expPerHourBase + " EXP/h";
			form.lbl_jexp_hour.Text = expPerHourJob + " EXP/h";
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
