//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp.BatchVariables {
	/// <summary>
	/// Represents a FIELD or ARRAY node inside a structured variable response.
	/// </summary>
	public class CgtpStructureField {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public CgtpStructureField()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Field or array element name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Text content of this node. Null if this node has children.
		/// </summary>
		public string StringValue { get; set; }

		/// <summary>
		/// Whether this node is read-only on the controller
		/// </summary>
		public bool IsReadOnly { get; set; }

		/// <summary>
		/// True if this node was an ARRAY element, false if it was a FIELD
		/// </summary>
		public bool IsArray { get; set; }

		/// <summary>
		/// Child nodes (FIELD and ARRAY elements). Null if this is a leaf node.
		/// </summary>
		public CgtpStructureField[] Children { get; set; }
	}
}
