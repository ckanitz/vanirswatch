/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 12.07.2017
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Vanirs_Watch
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class VanirsWatch
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try {
				Application.Run(new MainForm());
			} catch( Exception ex ) {
				string message = ex.Message;
                string caption = "ERROR";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
		
				// Displays the MessageBox.
		
				result = MessageBox.Show(message, caption, buttons);
		
				if (result == System.Windows.Forms.DialogResult.OK)
				{
					// Closes the parent form.
					Application.Exit();					
				}
			}
		}
		
	}
}
