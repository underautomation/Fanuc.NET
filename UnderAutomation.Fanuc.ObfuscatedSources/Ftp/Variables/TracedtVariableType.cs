//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACEDT_T
	/// </summary>
	public class TracedtVariableType : GenericVariableType, IGenericVariableType {


		public TracedtVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $EPT_INDEX
		/// </summary>
		public short EptIndex { get; }

		/// <summary>
		/// Value of variable $LINE_NUM
		/// </summary>
		public short LineNum { get; }

		/// <summary>
		/// Value of variable $FILE_OFST
		/// </summary>
		public short FileOfst { get; }

		/// <summary>
		/// Value of variable $EXEC_TYPE
		/// </summary>
		public byte ExecType { get; }

		/// <summary>
		/// Value of variable $LINE_ST
		/// </summary>
		public byte LineSt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
