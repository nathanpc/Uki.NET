using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Uki {
	public class Workspace {
		private string rootPath;
		private List<Property> properties;
		private List<Property> variables;

		/// <summary>
		/// Initializes an empty workspace.
		/// </summary>
		public Workspace() {
			properties = new List<Property>();
			variables = new List<Property>();
		}

		/// <summary>
		/// Initializes a workspace object with a workspace root path.
		/// </summary>
		/// <param name="path">Path to the workspace root.</param>
		public Workspace(string path) : this() {
			// Set workspace root path.
			Root = path;

			// Parse manifests.
			properties = ParseManifest(Path.Combine(Root, Constants.MANIFEST_PATH));
			variables = ParseManifest(Path.Combine(Root, Constants.VARIABLES_PATH));
		}

		/// <summary>
		/// Parses a manifest file.
		/// </summary>
		/// <param name="path">Path to the manifest.</param>
		/// <returns>A property list gathered from the manifest file.</returns>
		public static List<Property> ParseManifest(string path) {
			List<Property> props = new List<Property>();

			// Go through manifest file lines.
			foreach (string line in File.ReadAllLines(path)) {
				props.Add(new Property(line));
			}

			return props;
		}

		/// <summary>
		/// Path to the root of the workspace.
		/// </summary>
		public string Root {
			get { return rootPath; }
			set { rootPath = value; }
		}

		/// <summary>
		/// Workspace manifest properties.
		/// </summary>
		public List<Property> Properties {
			get { return properties; }
		}

		/// <summary>
		/// Workspace variables.
		/// </summary>
		public List<Property> Variables {
			get { return variables; }
		}

		/// <summary>
		/// Gets a human-readable string representation of the workspace.
		/// </summary>
		/// <returns>A human-readable string representation of the object.</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();

			// Workspace path.
			sb.AppendLine("Root Path: " + Root);

			// Workspace manifest.
			sb.AppendLine("Properties:");
			foreach (Property prop in Properties) {
				sb.AppendLine("    " + prop.ToString());
			}

			// Workspace variables.
			sb.AppendLine("Variables:");
			foreach (Property prop in Variables) {
				sb.AppendLine("    " + prop.ToString());
			}

			return sb.ToString();
		}
	}
}
