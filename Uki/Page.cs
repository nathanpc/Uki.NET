using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Uki {
	public class Page {
		private string path;
		private string folder;
		private string name;

		/// <summary>
		/// Initializes an empty page.
		/// </summary>
		public Page() {
		}

		/// <summary>
		/// Initializes a page from a file path.
		/// </summary>
		/// <param name="workspace">Workspace the page belongs to.</param>
		/// <param name="filePath">Path to the page file.</param>
		public Page(Workspace workspace, string filePath) {
			FilePath = filePath;
			Name = Path.GetFileNameWithoutExtension(FilePath);

			// Get the folder of the page.
			folder = filePath.Substring(workspace.Root.Length + 1);
			folder = folder.Substring(folder.IndexOf(Path.DirectorySeparatorChar));
			folder = folder.Substring(0, folder.Length -
				Path.GetFileName(filePath).Length);
		}

		/// <summary>
		/// Absolute path to the page.
		/// </summary>
		public string FilePath {
			get { return path; }
			set { path = value; }
		}

		/// <summary>
		/// Page folder relative to the workspace page folder.
		/// </summary>
		public string Folder {
			get { return folder; }
			set { folder = value; }
		}

		/// <summary>
		/// Page name.
		/// </summary>
		public string Name {
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets a human-readable string representation of this page for debugging purposes.
		/// </summary>
		/// <returns>Human-readable string representation of the page.</returns>
		public string ToDebugString() {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Name: " + Name);
			sb.AppendLine("Folder: " + Folder);
			sb.AppendLine("Path: " + FilePath);

			return sb.ToString();
		}

		/// <summary>
		/// Gets the string representation of the page.
		/// </summary>
		/// <returns>Page name.</returns>
		public override string ToString() {
			return Name;
		}
	}
}
