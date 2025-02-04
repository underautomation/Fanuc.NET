//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DBTB_CTRL_T
	/// </summary>
	public class DbtbCtrlVariableType : GenericVariableType, IGenericVariableType {


		public DbtbCtrlVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ACRT_MODE
		/// </summary>
		public bool AcrtMode { get; }

		/// <summary>
		/// Value of variable $MINDT_ADJ
		/// </summary>
		public bool MindtAdj { get; }

		/// <summary>
		/// Value of variable $DELAY_CALL
		/// </summary>
		public short DelayCall { get; }

		/// <summary>
		/// Value of variable $DELAY_DO
		/// </summary>
		public short DelayDo { get; }

		/// <summary>
		/// Value of variable $DELAY_PLS
		/// </summary>
		public short DelayPls { get; }

		/// <summary>
		/// Value of variable $RSM_WAIT
		/// </summary>
		public short RsmWait { get; }

		/// <summary>
		/// Value of variable $RESERVED2
		/// </summary>
		public short Reserved2 { get; }

		/// <summary>
		/// Value of variable $RESERVED3
		/// </summary>
		public short Reserved3 { get; }

		/// <summary>
		/// Value of variable $NUM_IO
		/// </summary>
		public short NumIo { get; }

		/// <summary>
		/// Value of variable $DUMMY9
		/// </summary>
		public byte Dummy9 { get; }

		/// <summary>
		/// Value of variable $DUMMY10
		/// </summary>
		public byte Dummy10 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
