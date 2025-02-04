//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FDOT_T
	/// </summary>
	public class FdotVariableType : GenericVariableType, IGenericVariableType {


		public FdotVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable NUM_ITERATIO
		/// </summary>
		public int NumIteratio { get; }

		/// <summary>
		/// Value of variable EQUAL_THRES
		/// </summary>
		public double EqualThres { get; }

		/// <summary>
		/// Value of variable AREA_THRES
		/// </summary>
		public double AreaThres { get; }

		/// <summary>
		/// Value of variable ANGLE_THRES
		/// </summary>
		public double AngleThres { get; }

		/// <summary>
		/// Value of variable DIFF_PITCH
		/// </summary>
		public double DiffPitch { get; }

		/// <summary>
		/// Value of variable CONV_THRES
		/// </summary>
		public double ConvThres { get; }

		/// <summary>
		/// Value of variable W_P_RATE
		/// </summary>
		public double WPRate { get; }

		/// <summary>
		/// Value of variable RESIDUAL_ERR
		/// </summary>
		public double ResidualErr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
