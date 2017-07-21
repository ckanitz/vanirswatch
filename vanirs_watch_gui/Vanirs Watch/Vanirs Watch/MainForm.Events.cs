/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 21.07.2017
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vanirs_Watch
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	partial class MainForm
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
			public static extern int SendMessage(IntPtr hWnd, 
			                 int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
	
		/// <summary>
		/// Handle dragging of the window with the left mouse-key
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
		    {
		        ReleaseCapture();
		        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		    }
		}
		
		/// <summary>
		/// Handle application close
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Btn_closeClick(object sender, EventArgs e)
		{
			if (System.Windows.Forms.Application.MessageLoop) 
			{
			    // WinForms app
			    this.killProgram();
			}
			else
			{
			    // Console app
			    System.Environment.Exit(1);
			}
		}
		
		/// <summary>
		/// Handle minimize window
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Btn_minimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void Btn_startClick(object sender, EventArgs e)
		{
			if ( btn_start.Text == "START" ) {
				myTimer.Start();
				btn_start.Text = "PAUSE";
			} else {
				myTimer.Stop();
				btn_start.Text = "START";
			}
		}
		void btn_resetClick(object sender, EventArgs e)
		{
			myTimer.Stop();
			btn_start.Text = "START";
			prevBaseEXP = 0;
	        prevJobEXP = 0;
			gainedExpBase = 0;
	        gainedExpJob = 0;
	        expPerHourBase = 0;
	        expPerHourJob = 0;
	        lbl_bexp_hour.Text = expPerHourBase + " EXP/h";
			lbl_jexp_hour.Text = expPerHourJob + " EXP/h";
		}
	}
}
