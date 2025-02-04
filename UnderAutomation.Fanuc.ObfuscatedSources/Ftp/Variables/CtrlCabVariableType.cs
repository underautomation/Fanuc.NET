//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CTRL_CAB_T
	/// </summary>
	public class CtrlCabVariableType : GenericVariableType, IGenericVariableType {


		public CtrlCabVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TRANS_A
		/// </summary>
		public double TransA { get; }

		/// <summary>
		/// Value of variable $IDLE_PWR
		/// </summary>
		public double IdlePwr { get; }

		/// <summary>
		/// Value of variable $AMP_COEFB
		/// </summary>
		public double AmpCoefb { get; }

		/// <summary>
		/// Value of variable $SV_NUM
		/// </summary>
		public int SvNum { get; }

		/// <summary>
		/// Value of variable $SV_AMP
		/// </summary>
		public AmpCoefVariableType[] SvAmp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
