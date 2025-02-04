//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PSLGSET_T
	/// </summary>
	public class PslgsetVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PS_SIZE
		/// </summary>
		public int PsSize { get; }

		/// <summary>
		/// Value of variable $PS_MODE
		/// </summary>
		public int PsMode { get; }

		/// <summary>
		/// Value of variable $TIMESENT
		/// </summary>
		public int Timesent { get; }

		/// <summary>
		/// Value of variable $LASTDEV
		/// </summary>
		public string Lastdev { get; }

		/// <summary>
		/// Value of variable $PS_DEBUG
		/// </summary>
		public int PsDebug { get; }

		/// <summary>
		/// Value of variable $TIMESENT2
		/// </summary>
		public int Timesent2 { get; }

		/// <summary>
		/// Value of variable $LASTDEV2
		/// </summary>
		public string Lastdev2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
