//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USRTOL_GRP_T
	/// </summary>
	public class UsrtolGrpVariableType : GenericVariableType, IGenericVariableType {


		public UsrtolGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DIST_TOL
		/// </summary>
		public double DistTol { get; }

		/// <summary>
		/// Value of variable $ORNT_TOL
		/// </summary>
		public double OrntTol { get; }

		/// <summary>
		/// Value of variable $RAUX_TOL
		/// </summary>
		public double RauxTol { get; }

		/// <summary>
		/// Value of variable $TAUX_TOL
		/// </summary>
		public double TauxTol { get; }

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
