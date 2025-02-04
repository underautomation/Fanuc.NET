//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PG_DEFSPD_T
	/// </summary>
	public class PgDefspdVariableType : GenericVariableType, IGenericVariableType {


		public PgDefspdVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $AP_DEF_SPD
		/// </summary>
		public short ApDefSpd { get; }

		/// <summary>
		/// Value of variable $AP_DEF_UNIT
		/// </summary>
		public byte ApDefUnit { get; }

		/// <summary>
		/// Value of variable $DUMMY4
		/// </summary>
		public byte Dummy4 { get; }

		/// <summary>
		/// Value of variable $APSP_PREXE
		/// </summary>
		public bool ApspPrexe { get; }

		/// <summary>
		/// Value of variable $DLY_LASTPS
		/// </summary>
		public int DlyLastps { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
