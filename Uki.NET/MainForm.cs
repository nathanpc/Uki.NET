using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Uki.NET {
	public partial class MainForm : Form {
		private Workspace workspace;

		public MainForm() {
			// Open a new workspace and test it out.
			workspace = new Workspace(@"C:\Documents and Settings\Administrator\My Documents\TestUki");
			Debug.Print(workspace.ToString());
			
			InitializeComponent();
		}
	}
}