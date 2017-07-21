/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 12.07.2017
 */
using System;
using System.Windows.Forms;

namespace Vanirs_Watch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		public MainForm()
		{
			InitializeComponent();
			InitializeUpdate();
		}
		
		void killProgram() {
			System.Windows.Forms.Application.Exit();
		}
	}
}
