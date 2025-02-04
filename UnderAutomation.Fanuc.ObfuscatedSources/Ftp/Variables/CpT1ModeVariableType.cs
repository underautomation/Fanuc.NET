//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CP_T1_MODE_T
	/// </summary>
	public class CpT1ModeVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $COMP_SWITCH
		/// </summary>
		public int CompSwitch { get; }

		/// <summary>
		/// Value of variable $MARGIN
		/// </summary>
		public int Margin { get; }

		/// <summary>
		/// Value of variable $TIME_FACTOR
		/// </summary>
		public double TimeFactor { get; }

		/// <summary>
		/// Value of variable $SPD_LIMIT
		/// </summary>
		public double SpdLimit { get; }

		/// <summary>
		/// Value of variable $SLEW_RATE
		/// </summary>
		public double SlewRate { get; }

		/// <summary>
		/// Value of variable $MIN_TFLEN
		/// </summary>
		public int MinTflen { get; }

		/// <summary>
		/// Value of variable $EXTRA_INT
		/// </summary>
		public int[] ExtraInt { get; }

		/// <summary>
		/// Value of variable $EXTRA_FLT
		/// </summary>
		public double[] ExtraFlt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
