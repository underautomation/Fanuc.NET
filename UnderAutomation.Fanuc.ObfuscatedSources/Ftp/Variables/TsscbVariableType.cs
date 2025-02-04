//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TSSCB_T
	/// </summary>
	public class TsscbVariableType : GenericVariableType, IGenericVariableType {


		public TsscbVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DSP_NO
		/// </summary>
		public byte DspNo { get; }

		/// <summary>
		/// Value of variable $DSPAX_NO
		/// </summary>
		public byte DspaxNo { get; }

		/// <summary>
		/// Value of variable $DATA_SEL
		/// </summary>
		public byte DataSel { get; }

		/// <summary>
		/// Value of variable $OUT_CHANNEL
		/// </summary>
		public byte OutChannel { get; }

		/// <summary>
		/// Value of variable $ADDRESS
		/// </summary>
		public int Address { get; }

		/// <summary>
		/// Value of variable $BIT_SHIFT
		/// </summary>
		public int BitShift { get; }

		/// <summary>
		/// Value of variable $USE_2CH
		/// </summary>
		public short Use2ch { get; }

		/// <summary>
		/// Value of variable $MONITOR
		/// </summary>
		public short Monitor { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
