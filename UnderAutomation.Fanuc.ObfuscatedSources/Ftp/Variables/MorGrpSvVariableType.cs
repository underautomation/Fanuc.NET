//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MOR_GRP_SV_T
	/// </summary>
	public class MorGrpSvVariableType : GenericVariableType, IGenericVariableType {


		public MorGrpSvVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CUR_SV_ANG
		/// </summary>
		public double[] CurSvAng { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
