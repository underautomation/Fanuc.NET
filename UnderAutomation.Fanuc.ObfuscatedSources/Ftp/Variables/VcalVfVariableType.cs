//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCAL_VF_T
	/// </summary>
	public class VcalVfVariableType : GenericVariableType, IGenericVariableType {


		public VcalVfVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable TRGT_VAL_VT
		/// </summary>
		public double TrgtValVt { get; }

		/// <summary>
		/// Value of variable TRGT_VAL_HZ
		/// </summary>
		public double TrgtValHz { get; }

		/// <summary>
		/// Value of variable TRGT_VAL_S
		/// </summary>
		public double TrgtValS { get; }

		/// <summary>
		/// Value of variable VFB_MAT
		/// </summary>
		public double[,] VfbMat { get; }

		/// <summary>
		/// Value of variable MAT_SIZE
		/// </summary>
		public double MatSize { get; }

		/// <summary>
		/// Value of variable VFB_TOL
		/// </summary>
		public double VfbTol { get; }

		/// <summary>
		/// Value of variable VFB_LIMIT
		/// </summary>
		public double VfbLimit { get; }

		/// <summary>
		/// Value of variable MAX_LOOP
		/// </summary>
		public int MaxLoop { get; }

		/// <summary>
		/// Value of variable HAND_EYE
		/// </summary>
		public bool HandEye { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
