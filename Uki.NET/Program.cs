using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Uki;

namespace Uki.NET {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// Open a new workspace and test it out.
			Workspace workspace = new Workspace(@"C:\Documents and Settings\Administrator\My Documents\TestUki");
			Debug.Print(workspace.ToString());
			
			// Setup and run the main application form.
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}