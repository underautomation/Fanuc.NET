//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGADJ_T
	/// </summary>
	public class PrgadjVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $X_LIMIT
		/// </summary>
		public double XLimit { get; }

		/// <summary>
		/// Value of variable $Y_LIMIT
		/// </summary>
		public double YLimit { get; }

		/// <summary>
		/// Value of variable $Z_LIMIT
		/// </summary>
		public double ZLimit { get; }

		/// <summary>
		/// Value of variable $W_LIMIT
		/// </summary>
		public double WLimit { get; }

		/// <summary>
		/// Value of variable $P_LIMIT
		/// </summary>
		public double PLimit { get; }

		/// <summary>
		/// Value of variable $R_LIMIT
		/// </summary>
		public double RLimit { get; }

		/// <summary>
		/// Value of variable $SPEED_ADJ
		/// </summary>
		public int SpeedAdj { get; }

		/// <summary>
		/// Value of variable $NEXT_CYCLE
		/// </summary>
		public bool NextCycle { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
