//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FILE_SETUP_T
	/// </summary>
	public class FileSetupVariableType : GenericVariableType, IGenericVariableType {


		public FileSetupVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FILE_BASEPT
		/// </summary>
		public int FileBasept { get; }

		/// <summary>
		/// Value of variable $FILECOMP
		/// </summary>
		public FilecompVariableType Filecomp { get; }

		/// <summary>
		/// Value of variable $FILE_MASK
		/// </summary>
		public bool FileMask { get; }

		/// <summary>
		/// Value of variable $FILE_TD_SEC
		/// </summary>
		public int FileTdSec { get; }

		/// <summary>
		/// Value of variable $FAT_TYP_MSK
		/// </summary>
		public short FatTypMsk { get; }

		/// <summary>
		/// Value of variable $FAL_SAF_MSK
		/// </summary>
		public short FalSafMsk { get; }

		/// <summary>
		/// Value of variable $OPEN_FILES
		/// </summary>
		public int OpenFiles { get; }

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $MENU_CNTRL
		/// </summary>
		public int MenuCntrl { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
