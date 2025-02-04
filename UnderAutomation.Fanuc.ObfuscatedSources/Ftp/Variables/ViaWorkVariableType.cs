//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VIA_WORK_T
	/// </summary>
	public class ViaWorkVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $HDR
		/// </summary>
		public byte[] Hdr { get; }

		/// <summary>
		/// Value of variable $JOINT_POS
		/// </summary>
		public JointPositionVariable JointPos { get; }

		/// <summary>
		/// Value of variable $Z_UPLIM
		/// </summary>
		public double ZUplim { get; }

		/// <summary>
		/// Value of variable $Z_LOWLIM
		/// </summary>
		public double ZLowlim { get; }

		/// <summary>
		/// Value of variable $VIA_CREATED
		/// </summary>
		public bool ViaCreated { get; }

		/// <summary>
		/// Value of variable $CUR_LIN
		/// </summary>
		public short CurLin { get; }

		/// <summary>
		/// Value of variable $EPT_IDX
		/// </summary>
		public short EptIdx { get; }

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public short TaskId { get; }

		/// <summary>
		/// Value of variable $INT_VIA_MOD
		/// </summary>
		public byte IntViaMod { get; }

		/// <summary>
		/// Value of variable $RESERVED
		/// </summary>
		public byte Reserved { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
