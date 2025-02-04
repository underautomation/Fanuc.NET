//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HIST_ELE_T
	/// </summary>
	public class HistEleVariableType : GenericVariableType, IGenericVariableType {


		public HistEleVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TIME_STAMP
		/// </summary>
		public short TimeStamp { get; }

		/// <summary>
		/// Value of variable $ON_TIME
		/// </summary>
		public short OnTime { get; }

		/// <summary>
		/// Value of variable $OFF_TIME
		/// </summary>
		public short OffTime { get; }

		/// <summary>
		/// Value of variable $ON_PERCENT
		/// </summary>
		public short OnPercent { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
