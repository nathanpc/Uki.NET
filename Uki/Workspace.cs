using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Uki {
	public class Workspace {
		private string rootPath;
		private List<Property> properties;
		private List<Property> variables;
		private List<Page> templates;
		private List<Page> articles;

		/// <summary>
		/// Initializes an empty workspace.
		/// </summary>
		public Workspace() {
			properties = new List<Property>();
			variables = new List<Property>();
			templates = new List<Page>();
			articles = new List<Page>();
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

			// Get articles and templates.
			templates = GetPages(Path.Combine(Root, Constants.TEMPLATE_ROOT));
			articles = GetPages(Path.Combine(Root, Constants.ARTICLE_ROOT));
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
		/// Gets the pages in a directory recursively.
		/// </summary>
		/// <returns>Pages in the directory.</returns>
		private List<Page> GetPages(string path) {
			List<Page> pages = new List<Page>();

			// Go through the articles sub-directories adding their contents to the list.
			foreach (string dir in Directory.GetDirectories(path)) {
				pages.AddRange(GetPages(dir));
			}

			// Go through the articles directory adding them to the articles list.
			foreach (string file in Directory.GetFiles(path)) {
				pages.Add(new Page(this, file));
			}

			return pages;
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
		/// Wiki name.
		/// </summary>
		public Property Name {
			get {
				foreach (Property variable in variables) {
					if (variable.Name == Constants.VAR_WIKI_NAME)
						return variable;
				}

				return null;
			}
		}

		/// <summary>
		/// Workspace articles.
		/// </summary>
		public List<Page> Articles {
			get { return articles; }
		}

		/// <summary>
		/// Workspace templates.
		/// </summary>
		public List<Page> Templates {
			get { return templates; }
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

			// Articles.
			sb.AppendLine("Templates:");
			foreach (Page page in templates) {
				sb.AppendLine(page.ToDebugString());
			}

			// Articles.
			sb.AppendLine("Articles:");
			foreach (Page page in articles) {
				sb.AppendLine(page.ToDebugString());
			}

			return sb.ToString();
		}
	}
}
