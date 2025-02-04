//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MNDSP_MST_T
	/// </summary>
	public class MndspMstVariableType : GenericVariableType, IGenericVariableType {


		public MndspMstVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DISP_ENABLE
		/// </summary>
		public bool DispEnable { get; }

		/// <summary>
		/// Value of variable $DISP_EDCMD
		/// </summary>
		public bool DispEdcmd { get; }

		/// <summary>
		/// Value of variable $DISP_INAUTO
		/// </summary>
		public bool DispInauto { get; }

		/// <summary>
		/// Value of variable $DISP_RSMDIS
		/// </summary>
		public bool DispRsmdis { get; }

		/// <summary>
		/// Value of variable $DISP_IS_ON
		/// </summary>
		public bool DispIsOn { get; }

		/// <summary>
		/// Value of variable $MODE_GRP
		/// </summary>
		public int[] ModeGrp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
