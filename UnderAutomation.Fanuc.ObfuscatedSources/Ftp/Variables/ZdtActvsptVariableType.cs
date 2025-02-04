//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ZDT_ACTVSPT_
	/// </summary>
	public class ZdtActvsptVariableType : GenericVariableType, IGenericVariableType {


		public ZdtActvsptVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ACTVSPT_ENB
		/// </summary>
		public bool ActvsptEnb { get; }

		/// <summary>
		/// Value of variable $ACTIVATE
		/// </summary>
		public int Activate { get; }

		/// <summary>
		/// Value of variable $IOTYPE
		/// </summary>
		public int Iotype { get; }

		/// <summary>
		/// Value of variable $IOPORT
		/// </summary>
		public int Ioport { get; }

		/// <summary>
		/// Value of variable $TIMEITVL
		/// </summary>
		public int Timeitvl { get; }

		/// <summary>
		/// Value of variable $TRGTDVC
		/// </summary>
		public string Trgtdvc { get; }

		/// <summary>
		/// Value of variable $TRGCFG
		/// </summary>
		public string Trgcfg { get; }

		/// <summary>
		/// Value of variable $TMPDIR
		/// </summary>
		public string Tmpdir { get; }

		/// <summary>
		/// Value of variable $PS_NUMFILE
		/// </summary>
		public short PsNumfile { get; }

		/// <summary>
		/// Value of variable $NUMFILE
		/// </summary>
		public int Numfile { get; }

		/// <summary>
		/// Value of variable $NUMCFG
		/// </summary>
		public int Numcfg { get; }

		/// <summary>
		/// Value of variable $LSTTIME
		/// </summary>
		public int Lsttime { get; }

		/// <summary>
		/// Value of variable $EXTRA
		/// </summary>
		public int Extra { get; }

		/// <summary>
		/// Value of variable $EXTRA_STR
		/// </summary>
		public string ExtraStr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
