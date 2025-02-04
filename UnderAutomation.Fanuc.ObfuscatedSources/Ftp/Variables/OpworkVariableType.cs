//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type OPWORK_T
	/// </summary>
	public class OpworkVariableType : GenericVariableType, IGenericVariableType {


		public OpworkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SYSBUSY
		/// </summary>
		public int Sysbusy { get; }

		/// <summary>
		/// Value of variable $SOPBUSYMSK
		/// </summary>
		public int Sopbusymsk { get; }

		/// <summary>
		/// Value of variable $TPBUSYMSK
		/// </summary>
		public int Tpbusymsk { get; }

		/// <summary>
		/// Value of variable $UOPBUSYMSK
		/// </summary>
		public int Uopbusymsk { get; }

		/// <summary>
		/// Value of variable $INTPRUNNING
		/// </summary>
		public int Intprunning { get; }

		/// <summary>
		/// Value of variable $INTPPAUSED
		/// </summary>
		public int Intppaused { get; }

		/// <summary>
		/// Value of variable $INTPMASK
		/// </summary>
		public int Intpmask { get; }

		/// <summary>
		/// Value of variable $OPT_OUT
		/// </summary>
		public byte OptOut { get; }

		/// <summary>
		/// Value of variable $UOP_DISABLE
		/// </summary>
		public byte UopDisable { get; }

		/// <summary>
		/// Value of variable $OUTIMAGE
		/// </summary>
		public short[] Outimage { get; }

		/// <summary>
		/// Value of variable $OP_PREV_IMG
		/// </summary>
		public short[] OpPrevImg { get; }

		/// <summary>
		/// Value of variable $OP_INV_MASK
		/// </summary>
		public short[] OpInvMask { get; }

		/// <summary>
		/// Value of variable $ORGOVRDVAL
		/// </summary>
		public int Orgovrdval { get; }

		/// <summary>
		/// Value of variable $USER_OUTPUT
		/// </summary>
		public short[] UserOutput { get; }

		/// <summary>
		/// Value of variable $ENBL_ON
		/// </summary>
		public int EnblOn { get; }

		/// <summary>
		/// Value of variable $MLT_RBT_ENB
		/// </summary>
		public byte MltRbtEnb { get; }

		/// <summary>
		/// Value of variable $NOALM_MSK
		/// </summary>
		public byte NoalmMsk { get; }

		/// <summary>
		/// Value of variable $DUMMY19
		/// </summary>
		public byte Dummy19 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
