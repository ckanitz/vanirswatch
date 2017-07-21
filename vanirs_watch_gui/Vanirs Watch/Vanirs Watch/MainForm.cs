/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 12.07.2017
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Vanirs_Watch.reader;

namespace Vanirs_Watch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		private const int INTERVAL = 1000;
		private static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		private static int tickCounter = 1;
		private static Reader r;
		private static View v;
		private static int baseEXP;
        private static int jobEXP;
		private static int prevBaseEXP = 0;
        private static int prevJobEXP = 0;

        // needed for exp/h buffer
        private static int gainedExpBase = 0;
        private static int gainedExpJob = 0;
        private static int expPerHourBase = 0;
        private static int expPerHourJob = 0;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, 
		                 int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			try {
				this.r = new Reader();
				this.v = new View();
			} catch( Exception ex ) {
				throw new Exception( ex.Message );
			}
			InitializeComponent();

			myTimer.Tick += new EventHandler(TimerEventProcessor);

			// Sets the timer interval to 1 second.
			myTimer.Interval = this.INTERVAL;
		}
		
		void killProgram() {
			System.Windows.Forms.Application.Exit();
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
            
            v.updateForm();
		}
		
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
