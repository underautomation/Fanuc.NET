//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PODATA_T
	/// </summary>
	public class PodataVariableType : GenericVariableType, IGenericVariableType {


		public PodataVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $OVERRUN_CNT
		/// </summary>
		public int OverrunCnt { get; }

		/// <summary>
		/// Value of variable $CUR_INDEX
		/// </summary>
		public int CurIndex { get; }

		/// <summary>
		/// Value of variable $PROGRAM_ID
		/// </summary>
		public short[] ProgramId { get; }

		/// <summary>
		/// Value of variable $LINE_NO
		/// </summary>
		public short[] LineNo { get; }

		/// <summary>
		/// Value of variable $OVERRUN_ITP
		/// </summary>
		public short[] OverrunItp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
