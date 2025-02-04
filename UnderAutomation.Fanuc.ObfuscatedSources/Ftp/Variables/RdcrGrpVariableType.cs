//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RDCR_GRP_T
	/// </summary>
	public class RdcrGrpVariableType : GenericVariableType, IGenericVariableType {


		public RdcrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $RMAX_TORQUE
		/// </summary>
		public double[] RmaxTorque { get; }

		/// <summary>
		/// Value of variable $RMIN_TORQUE
		/// </summary>
		public double[] RminTorque { get; }

		/// <summary>
		/// Value of variable $THRES_TORQ
		/// </summary>
		public double[] ThresTorq { get; }

		/// <summary>
		/// Value of variable $RGEAR_RATIO
		/// </summary>
		public double[] RgearRatio { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Value of variable $RESERVE
		/// </summary>
		public double[] Reserve { get; }

		/// <summary>
		/// Value of variable $SPC_ITP
		/// </summary>
		public int SpcItp { get; }

		/// <summary>
		/// Value of variable $NUM_EXD
		/// </summary>
		public int NumExd { get; }

		/// <summary>
		/// Value of variable $J2TH2ND
		/// </summary>
		public double J2th2nd { get; }

		/// <summary>
		/// Value of variable $J2RED
		/// </summary>
		public J2redVariableType[] J2red { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
