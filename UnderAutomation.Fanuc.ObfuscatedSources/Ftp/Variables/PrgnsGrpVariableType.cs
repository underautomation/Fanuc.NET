//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGNS_GRP_T
	/// </summary>
	public class PrgnsGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ELEM
		/// </summary>
		public PrgnsElemVariableType[] Elem { get; }

		/// <summary>
		/// Value of variable $MIN_ANG
		/// </summary>
		public double[] MinAng { get; }

		/// <summary>
		/// Value of variable $MAX_ANG
		/// </summary>
		public double[] MaxAng { get; }

		/// <summary>
		/// Value of variable $BASE_ANG
		/// </summary>
		public double[] BaseAng { get; }

		/// <summary>
		/// Value of variable $LAST_MOD
		/// </summary>
		public int[] LastMod { get; }

		/// <summary>
		/// Value of variable $BASE_MOD
		/// </summary>
		public int[] BaseMod { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public int Payload { get; }

		/// <summary>
		/// Value of variable $WARN_DOUT
		/// </summary>
		public int WarnDout { get; }

		/// <summary>
		/// Value of variable $WARN_DIN
		/// </summary>
		public int WarnDin { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
