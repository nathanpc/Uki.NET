using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Uki.NET {
	public partial class MainForm : Form {
		private Workspace workspace;

		/// <summary>
		/// Initializes the form.
		/// </summary>
		public MainForm() {
			// Open a new workspace and test it out.
			workspace = new Workspace(@"C:\Documents and Settings\Administrator\My Documents\TestUki");
			Debug.Print(workspace.ToString());
			
			// Initialize and display window components.
			InitializeComponent();
			PopulateTreeView();
		}

		/// <summary>
		/// Populates the TreeView with articles and templates.
		/// </summary>
		private void PopulateTreeView() {
			List<string> paths = new List<string>();
			Property name = workspace.Name;

			// Check if the wiki has a name.
			if (name == null)
				name = new Property(Constants.VAR_WIKI_NAME, "Workspace");

			// Populate the paths list with articles.
			foreach (Page page in workspace.Articles) {
				paths.Add(name.Value + Path.DirectorySeparatorChar + "Articles" +
					page.Folder + page.ToString());
			}

			// Populate the paths list with templates.
			foreach (Page page in workspace.Templates) {
				paths.Add(name.Value + Path.DirectorySeparatorChar + "Templates" +
					page.Folder + page.ToString());
			}

			// Populate the TreeView and expand the tree nodes.
			PopulateTreeViewFromPaths(treeView, paths, Path.DirectorySeparatorChar);
			treeView.ExpandAll();
		}

		/// <summary>
		/// Populates a TreeView from a list of paths.
		/// </summary>
		/// <see cref="https://stackoverflow.com/a/1768414/126353" />
		/// <param name="treeView">TreeView to be populated.</param>
		/// <param name="paths">Paths to populate with.</param>
		/// <param name="pathSeparator">Path separator character.</param>
		private static void PopulateTreeViewFromPaths(TreeView treeView, IEnumerable<string> paths, char pathSeparator) {
			TreeNode lastNode = null;
			string subPathAgg;

			foreach (string path in paths) {
				subPathAgg = string.Empty;

				foreach (string subPath in path.Split(pathSeparator)) {
					subPathAgg += subPath + pathSeparator;
					TreeNode[] nodes = treeView.Nodes.Find(subPathAgg, true);

					if (nodes.Length == 0) {
						if (lastNode == null) {
							lastNode = treeView.Nodes.Add(subPathAgg, subPath);
						} else {
							lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
						}
					} else {
						lastNode = nodes[0];
					}
				}
			}
		}
	}
}