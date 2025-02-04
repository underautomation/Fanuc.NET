//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBJ2_GRP_T
	/// </summary>
	public class Tbj2GrpVariableType : GenericVariableType, IGenericVariableType {


		public Tbj2GrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENB_FLIM
		/// </summary>
		public bool EnbFlim { get; }

		/// <summary>
		/// Value of variable $LIM_FTM1
		/// </summary>
		public int LimFtm1 { get; }

		/// <summary>
		/// Value of variable $LIM_FTM2
		/// </summary>
		public int LimFtm2 { get; }

		/// <summary>
		/// Value of variable $RESERVE1
		/// </summary>
		public int Reserve1 { get; }

		/// <summary>
		/// Value of variable $RESERVE2
		/// </summary>
		public int Reserve2 { get; }

		/// <summary>
		/// Value of variable $RESERVE3
		/// </summary>
		public int Reserve3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
