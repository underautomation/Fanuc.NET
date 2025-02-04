//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLID_CLLB_T
	/// </summary>
	public class PlidCllbVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $BARECD_DONE
		/// </summary>
		public int BarecdDone { get; }

		/// <summary>
		/// Value of variable $BAMOVE_DIR
		/// </summary>
		public int BamoveDir { get; }

		/// <summary>
		/// Value of variable $BAMOVE_DIS
		/// </summary>
		public double BamoveDis { get; }

		/// <summary>
		/// Value of variable $BAJ5_DEG
		/// </summary>
		public double Baj5Deg { get; }

		/// <summary>
		/// Value of variable $BAJ6_DEG
		/// </summary>
		public double Baj6Deg { get; }

		/// <summary>
		/// Value of variable $MASS_KNOWN
		/// </summary>
		public int MassKnown { get; }

		/// <summary>
		/// Value of variable $MASS_VALUE
		/// </summary>
		public double MassValue { get; }

		/// <summary>
		/// Value of variable $ADRECD_DONE
		/// </summary>
		public int[] AdrecdDone { get; }

		/// <summary>
		/// Value of variable $ADUSE_DONE
		/// </summary>
		public int[] AduseDone { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_X
		/// </summary>
		public double PayloadX { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Y
		/// </summary>
		public double PayloadY { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Z
		/// </summary>
		public double PayloadZ { get; }

		/// <summary>
		/// Value of variable $PLNUM_AP
		/// </summary>
		public int PlnumAp { get; }

		/// <summary>
		/// Value of variable $PLCL_POS
		/// </summary>
		public CartesianPositionVariable[] PlclPos { get; }

		/// <summary>
		/// Value of variable $PLCL_DIS
		/// </summary>
		public double[] PlclDis { get; }

		/// <summary>
		/// Value of variable $PLCL_UT
		/// </summary>
		public int[] PlclUt { get; }

		/// <summary>
		/// Value of variable $PLCL_UF
		/// </summary>
		public int[] PlclUf { get; }

		/// <summary>
		/// Value of variable $PLCL_CRPO
		/// </summary>
		public int PlclCrpo { get; }

		/// <summary>
		/// Value of variable $PLCL_POSID
		/// </summary>
		public int PlclPosid { get; }

		/// <summary>
		/// Value of variable $PLCL_ESTI
		/// </summary>
		public int PlclEsti { get; }

		/// <summary>
		/// Value of variable $PLCL_PROST
		/// </summary>
		public int PlclProst { get; }

		/// <summary>
		/// Value of variable $PLCL_AXISM
		/// </summary>
		public double[] PlclAxism { get; }

		/// <summary>
		/// Value of variable $BASEPOS_J
		/// </summary>
		public bool BaseposJ { get; }

		/// <summary>
		/// Value of variable $BASE_JPOS
		/// </summary>
		public double[] BaseJpos { get; }

		/// <summary>
		/// Value of variable $EXTAND_AXIS
		/// </summary>
		public bool ExtandAxis { get; }

		/// <summary>
		/// Value of variable $EXTAND_POS
		/// </summary>
		public double[] ExtandPos { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
