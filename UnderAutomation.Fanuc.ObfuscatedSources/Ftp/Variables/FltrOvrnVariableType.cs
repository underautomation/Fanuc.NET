//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $FLTR_OVRN
	/// </summary>
	public class FltrOvrnVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $LIMIT_TICK
		/// </summary>
		public int LimitTick { get; }

		/// <summary>
		/// Value of variable $OVERRUN_CNT
		/// </summary>
		public int OverrunCnt { get; }

		/// <summary>
		/// Value of variable $MAX_TICK
		/// </summary>
		public int MaxTick { get; }

		/// <summary>
		/// Value of variable $ITP_COUNT
		/// </summary>
		public int ItpCount { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
