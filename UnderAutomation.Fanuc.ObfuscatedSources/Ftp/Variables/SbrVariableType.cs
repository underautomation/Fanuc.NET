//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SBR_T
	/// </summary>
	public class SbrVariableType : GenericVariableType, IGenericVariableType {


		public SbrVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SVMTR_ID
		/// </summary>
		public int SvmtrId { get; }

		/// <summary>
		/// Value of variable $ROBOT_ID
		/// </summary>
		public string RobotId { get; }

		/// <summary>
		/// Value of variable $GRP_NUM
		/// </summary>
		public int GrpNum { get; }

		/// <summary>
		/// Value of variable $AXIS_NUM
		/// </summary>
		public int AxisNum { get; }

		/// <summary>
		/// Value of variable $MTR_ID
		/// </summary>
		public string MtrId { get; }

		/// <summary>
		/// Value of variable $MTR_INF_ID
		/// </summary>
		public string MtrInfId { get; }

		/// <summary>
		/// Value of variable $SV_PARAM_ID
		/// </summary>
		public string SvParamId { get; }

		/// <summary>
		/// Value of variable $PARAM
		/// </summary>
		public short[] Param { get; }

		/// <summary>
		/// Value of variable $MOT_SPD_LIM
		/// </summary>
		public int MotSpdLim { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
