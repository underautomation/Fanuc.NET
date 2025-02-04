//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLIM_GRP_T
	/// </summary>
	public class PlimGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MAX_PYLD
		/// </summary>
		public double MaxPyld { get; }

		/// <summary>
		/// Value of variable $AXISINERTIA
		/// </summary>
		public short[] Axisinertia { get; }

		/// <summary>
		/// Value of variable $AXISINERTIL
		/// </summary>
		public int[] Axisinertil { get; }

		/// <summary>
		/// Value of variable $AXISMOMENT
		/// </summary>
		public short[] Axismoment { get; }

		/// <summary>
		/// Value of variable $AXIS_IM_SCL
		/// </summary>
		public short AxisImScl { get; }

		/// <summary>
		/// Value of variable $LIM_WT_SCL
		/// </summary>
		public double LimWtScl { get; }

		/// <summary>
		/// Value of variable $LIM_INR_SCL
		/// </summary>
		public double[] LimInrScl { get; }

		/// <summary>
		/// Value of variable $LIM_MNT_SCL
		/// </summary>
		public double[] LimMntScl { get; }

		/// <summary>
		/// Value of variable $LIM_CL_SCL
		/// </summary>
		public double[] LimClScl { get; }

		/// <summary>
		/// Value of variable $PLD_MODE
		/// </summary>
		public short PldMode { get; }

		/// <summary>
		/// Value of variable $DUMMY11
		/// </summary>
		public byte Dummy11 { get; }

		/// <summary>
		/// Value of variable $DUMMY12
		/// </summary>
		public byte Dummy12 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
