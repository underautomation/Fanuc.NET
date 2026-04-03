//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Cgtp.BatchVariables {
	/// <summary>
	/// Represents a numeric register (R[]) for batch read/write operations.
	/// A numeric register always has a comment and a numeric value (integer or real).
	/// </summary>
	public class CgtpNumericRegister : NumericRegisterWithComment, ICgtpBatchVariable {

		/// <summary>
		/// 1-based index of the numeric register
		/// </summary>
		public int Index { get; }

		/// <summary>
		/// Full variable name (e.g. "$NUMREG[1]", "$POSREG[1,2]", "$RMT_MASTER")
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Program name that owns this variable
		/// </summary>
		public string Program { get; }

		/// <summary>
		/// Raw string value as read from or to be written to the controller
		/// </summary>
		public string StringValue { get; }

		/// <summary>
		/// Indicates whether a value was returned by the controller during a batch read.
		/// False if the variable was not found.
		/// </summary>
		public bool Exists { get; }

		/// <summary>
		/// Indicates whether the variable is uninitialized on the controller
		/// </summary>
		public bool IsUninitialized { get; }

		/// <summary>
		/// Indicates whether the variable is read-only on the controller and cannot be written with CGTP
		/// </summary>
		public bool IsReadOnly { get; }
	}
}
