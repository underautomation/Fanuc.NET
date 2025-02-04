//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HIST_DAY_T
	/// </summary>
	public class HistDayVariableType : GenericVariableType, IGenericVariableType {


		public HistDayVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DATE
		/// </summary>
		public int Date { get; }

		/// <summary>
		/// Value of variable $DATE_STR
		/// </summary>
		public string DateStr { get; }

		/// <summary>
		/// Value of variable $HIS_IDX_OFS
		/// </summary>
		public int HisIdxOfs { get; }

		/// <summary>
		/// Value of variable $HIST_DATA
		/// </summary>
		public HistEleVariableType[] HistData { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
