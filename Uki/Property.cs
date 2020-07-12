using System;
using System.Collections.Generic;
using System.Text;

namespace Uki {
	public class Property {
		private string name;
		private string value;

		/// <summary>
		/// Initializes an empty manifest property.
		/// </summary>
		public Property() {
		}

		/// <summary>
		/// Initializes a manifest property from a manifest line.
		/// </summary>
		/// <param name="line">Line from a manifest.</param>
		public Property(string line) : this() {
			string[] lineParts = line.Split('=');

			// Check if the manifest line is valid.
			if (lineParts.Length > 2) {
				throw new Exception("Manifest line can only contain one '=' character");
			} else if (lineParts.Length == 0) {
				throw new Exception("Manifest line doesn't contain an '=' character");
			}

			// Actually set the name and value.
			Name = lineParts[0];
			Value = lineParts[1];
		}

		/// <summary>
		/// Initializes a manifest property with a name and a value.
		/// </summary>
		/// <param name="name">Property name.</param>
		/// <param name="value">Property value.</param>
		public Property(string name, string value) : this() {
			Name = name;
			Value = value;
		}

		/// <summary>
		/// Property name.
		/// </summary>
		public string Name {
			get { return name; }
			set { name = value; }
		}
		
		/// <summary>
		/// Property value.
		/// </summary>
		public string Value {
			get { return this.value; }
			set { this.value = value; }
		}
	}
}
