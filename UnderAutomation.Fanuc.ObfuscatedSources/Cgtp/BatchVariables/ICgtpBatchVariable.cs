//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp.BatchVariables {
	/// <summary>
	/// Common interface for all batch variable types used with batch read/write operations.
	/// </summary>
	public interface ICgtpBatchVariable {

		/// <summary>
		/// Full variable name (e.g. "$NUMREG[1]", "$POSREG[1,2]", "$RMT_MASTER")
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Program name that owns this variable
		/// </summary>
		string Program { get; }

		/// <summary>
		/// Raw string value as read from or to be written to the controller
		/// </summary>
		string StringValue { get; }

		/// <summary>
		/// Indicates whether a value was returned by the controller during a batch read.
		/// False if the variable was not found.
		/// </summary>
		bool Exists { get; }

		/// <summary>
		/// Indicates whether the variable is uninitialized on the controller
		/// </summary>
		bool IsUninitialized { get; }

		/// <summary>
		/// Indicates whether the variable is read-only on the controller and cannot be written with CGTP
		/// </summary>
		bool IsReadOnly { get; }
	}
}
