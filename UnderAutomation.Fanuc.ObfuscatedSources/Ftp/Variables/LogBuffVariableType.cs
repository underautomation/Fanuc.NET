//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOG_BUFF_T
	/// </summary>
	public class LogBuffVariableType : GenericVariableType, IGenericVariableType {


		public LogBuffVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TITLE
		/// </summary>
		public string Title { get; }

		/// <summary>
		/// Value of variable $SIZE
		/// </summary>
		public int Size { get; }

		/// <summary>
		/// Value of variable $MEM_TYPE
		/// </summary>
		public int MemType { get; }

		/// <summary>
		/// Value of variable $VISIBLE
		/// </summary>
		public bool Visible { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
