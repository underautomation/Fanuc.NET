//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FTP_CTRL_T
	/// </summary>
	public class FtpCtrlVariableType : GenericVariableType, IGenericVariableType {


		public FtpCtrlVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LOG_ENTRIES
		/// </summary>
		public int LogEntries { get; }

		/// <summary>
		/// Value of variable $LOG_CMOS
		/// </summary>
		public bool LogCmos { get; }

		/// <summary>
		/// Value of variable $DNLD_FILTER
		/// </summary>
		public bool DnldFilter { get; }

		/// <summary>
		/// Value of variable $SUBDIRCAPS
		/// </summary>
		public bool Subdircaps { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
