//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACE_CFG_T
	/// </summary>
	public class TraceCfgVariableType : GenericVariableType, IGenericVariableType {


		public TraceCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $ITEMS
		/// </summary>
		public int Items { get; }

		/// <summary>
		/// Value of variable $CHANNELS
		/// </summary>
		public int Channels { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $TICKS
		/// </summary>
		public int Ticks { get; }

		/// <summary>
		/// Value of variable $MIN_MM
		/// </summary>
		public double MinMm { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
