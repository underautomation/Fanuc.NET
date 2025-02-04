//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file tpsnap.va
	/// </summary>
	public class TpsnapFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public TpsnapFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable DAY
		/// </summary>
		public int Day { get; }

		/// <summary>
		/// Value of variable DAY_STR
		/// </summary>
		public string DayStr { get; }

		/// <summary>
		/// Value of variable DEV_PATH_STR
		/// </summary>
		public string DevPathStr { get; }

		/// <summary>
		/// Value of variable DEV_STR
		/// </summary>
		public string DevStr { get; }

		/// <summary>
		/// Value of variable ENTRY
		/// </summary>
		public int Entry { get; }

		/// <summary>
		/// Value of variable HOUR
		/// </summary>
		public int Hour { get; }

		/// <summary>
		/// Value of variable HOUR_STR
		/// </summary>
		public string HourStr { get; }

		/// <summary>
		/// Value of variable LANG_STR
		/// </summary>
		public string LangStr { get; }

		/// <summary>
		/// Value of variable MIN
		/// </summary>
		public int Min { get; }

		/// <summary>
		/// Value of variable MIN_STR
		/// </summary>
		public string MinStr { get; }

		/// <summary>
		/// Value of variable MONTH
		/// </summary>
		public int Month { get; }

		/// <summary>
		/// Value of variable MONTH_STR
		/// </summary>
		public string MonthStr { get; }

		/// <summary>
		/// Value of variable PNG_STR
		/// </summary>
		public string PngStr { get; }

		/// <summary>
		/// Value of variable SEC
		/// </summary>
		public int Sec { get; }

		/// <summary>
		/// Value of variable SEC_STR
		/// </summary>
		public string SecStr { get; }

		/// <summary>
		/// Value of variable STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable TIME_INT
		/// </summary>
		public int TimeInt { get; }

		/// <summary>
		/// Value of variable TIME_STR
		/// </summary>
		public string TimeStr { get; }

		/// <summary>
		/// Value of variable TIME_STR2
		/// </summary>
		public string TimeStr2 { get; }

		/// <summary>
		/// Value of variable T_INT
		/// </summary>
		public int TInt { get; }

		/// <summary>
		/// Value of variable T_STR
		/// </summary>
		public string TStr { get; }

		/// <summary>
		/// Value of variable YEAR
		/// </summary>
		public int Year { get; }

		/// <summary>
		/// Value of variable YEAR_STR
		/// </summary>
		public string YearStr { get; }
	}
}
