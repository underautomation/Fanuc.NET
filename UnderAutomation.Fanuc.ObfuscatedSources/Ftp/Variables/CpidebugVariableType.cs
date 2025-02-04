//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CPIDEBUG
	/// </summary>
	public class CpidebugVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OUTPUT
		/// </summary>
		public int Output { get; }

		/// <summary>
		/// Value of variable $FILENAME
		/// </summary>
		public string Filename { get; }

		/// <summary>
		/// Value of variable $GROUP_MASK
		/// </summary>
		public int GroupMask { get; }

		/// <summary>
		/// Value of variable $DEBUGMASK
		/// </summary>
		public int Debugmask { get; }

		/// <summary>
		/// Value of variable $MAXDATA
		/// </summary>
		public int Maxdata { get; }

		/// <summary>
		/// Value of variable $COUNT
		/// </summary>
		public int Count { get; }

		/// <summary>
		/// Value of variable $TAIL
		/// </summary>
		public int Tail { get; }

		/// <summary>
		/// Value of variable $BUFEXIST
		/// </summary>
		public bool Bufexist { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
