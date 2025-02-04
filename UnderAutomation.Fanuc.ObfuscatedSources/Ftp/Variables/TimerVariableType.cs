//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TIMER_T
	/// </summary>
	public class TimerVariableType : GenericVariableType, IGenericVariableType {


		public TimerVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $TIMER_VAL
		/// </summary>
		public int TimerVal { get; }

		/// <summary>
		/// Value of variable $STR_EPT_IDX
		/// </summary>
		public short StrEptIdx { get; }

		/// <summary>
		/// Value of variable $STR_LIN_NUM
		/// </summary>
		public short StrLinNum { get; }

		/// <summary>
		/// Value of variable $END_EPT_IDX
		/// </summary>
		public short EndEptIdx { get; }

		/// <summary>
		/// Value of variable $END_LIN_NUM
		/// </summary>
		public short EndLinNum { get; }

		/// <summary>
		/// Value of variable $TID_NUM
		/// </summary>
		public byte TidNum { get; }

		/// <summary>
		/// Value of variable $DUMMY13
		/// </summary>
		public byte Dummy13 { get; }

		/// <summary>
		/// Value of variable $PS_OVERFLOW
		/// </summary>
		public short PsOverflow { get; }

		/// <summary>
		/// Value of variable $OVERFLOW
		/// </summary>
		public bool Overflow { get; }

		/// <summary>
		/// Value of variable $FLAG_TYPE
		/// </summary>
		public int FlagType { get; }

		/// <summary>
		/// Value of variable $FLAG_IDX
		/// </summary>
		public int FlagIdx { get; }

		/// <summary>
		/// Value of variable $GLB_TMR_ENB
		/// </summary>
		public bool GlbTmrEnb { get; }

		/// <summary>
		/// Value of variable $GLB_TMR_STR
		/// </summary>
		public bool GlbTmrStr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
