//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GP_HOLD_T
	/// </summary>
	public class GpHoldVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public short Status { get; }

		/// <summary>
		/// Value of variable $GP_MSK
		/// </summary>
		public short GpMsk { get; }

		/// <summary>
		/// Value of variable $SPACE_NUM
		/// </summary>
		public int SpaceNum { get; }

		/// <summary>
		/// Value of variable $CSPACE_NUM
		/// </summary>
		public int CspaceNum { get; }

		/// <summary>
		/// Value of variable $REQ_GRP
		/// </summary>
		public short ReqGrp { get; }

		/// <summary>
		/// Value of variable $PS_RATE
		/// </summary>
		public short PsRate { get; }

		/// <summary>
		/// Value of variable $RATE
		/// </summary>
		public double[] Rate { get; }

		/// <summary>
		/// Value of variable $INT_POS
		/// </summary>
		public double[] IntPos { get; }

		/// <summary>
		/// Value of variable $ACT_POS
		/// </summary>
		public double[] ActPos { get; }

		/// <summary>
		/// Value of variable $PRD_POS
		/// </summary>
		public double[] PrdPos { get; }

		/// <summary>
		/// Value of variable $S1
		/// </summary>
		public int S1 { get; }

		/// <summary>
		/// Value of variable $S2
		/// </summary>
		public int S2 { get; }

		/// <summary>
		/// Value of variable $S3
		/// </summary>
		public int S3 { get; }

		/// <summary>
		/// Value of variable $S4
		/// </summary>
		public int S4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
