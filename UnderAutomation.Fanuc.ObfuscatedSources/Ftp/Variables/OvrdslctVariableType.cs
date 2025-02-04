//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type OVRDSLCT_T
	/// </summary>
	public class OvrdslctVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OVSL_ENB
		/// </summary>
		public bool OvslEnb { get; }

		/// <summary>
		/// Value of variable $SDI_INDEX1
		/// </summary>
		public int SdiIndex1 { get; }

		/// <summary>
		/// Value of variable $SDI_INDEX2
		/// </summary>
		public int SdiIndex2 { get; }

		/// <summary>
		/// Value of variable $OFF_OFF_OVR
		/// </summary>
		public int OffOffOvr { get; }

		/// <summary>
		/// Value of variable $OFF_ON_OVRD
		/// </summary>
		public int OffOnOvrd { get; }

		/// <summary>
		/// Value of variable $ON_OFF_OVRD
		/// </summary>
		public int OnOffOvrd { get; }

		/// <summary>
		/// Value of variable $ON_ON_OVRD
		/// </summary>
		public int OnOnOvrd { get; }

		/// <summary>
		/// Value of variable $DUMMY
		/// </summary>
		public int Dummy { get; }

		/// <summary>
		/// Value of variable $DCS_CTL_ENB
		/// </summary>
		public bool DcsCtlEnb { get; }

		/// <summary>
		/// Value of variable $DCS_OVRD
		/// </summary>
		public int DcsOvrd { get; }

		/// <summary>
		/// Value of variable $OVRD_ZERO
		/// </summary>
		public bool OvrdZero { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
