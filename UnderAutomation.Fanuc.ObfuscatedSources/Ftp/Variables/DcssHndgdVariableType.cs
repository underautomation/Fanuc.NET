//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_HNDGD_T
	/// </summary>
	public class DcssHndgdVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GRP_NUM
		/// </summary>
		public int GrpNum { get; }

		/// <summary>
		/// Value of variable $SPEED_LIM
		/// </summary>
		public double SpeedLim { get; }

		/// <summary>
		/// Value of variable $DSBLIO_TYP
		/// </summary>
		public int DsblioTyp { get; }

		/// <summary>
		/// Value of variable $DSBLIO_IDX
		/// </summary>
		public int DsblioIdx { get; }

		/// <summary>
		/// Value of variable $STOP_TYPE
		/// </summary>
		public int StopType { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
