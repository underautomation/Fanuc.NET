//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SHELL_CHK_T
	/// </summary>
	public class ShellChkVariableType : GenericVariableType, IGenericVariableType {


		public ShellChkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $RESUME
		/// </summary>
		public bool Resume { get; }

		/// <summary>
		/// Value of variable $PROMPT
		/// </summary>
		public bool Prompt { get; }

		/// <summary>
		/// Value of variable $ERRPOST
		/// </summary>
		public bool Errpost { get; }

		/// <summary>
		/// Value of variable $FORCE
		/// </summary>
		public bool Force { get; }

		/// <summary>
		/// Value of variable $WARN
		/// </summary>
		public bool Warn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
