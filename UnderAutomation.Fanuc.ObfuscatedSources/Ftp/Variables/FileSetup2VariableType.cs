//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FILE_SETUP2_
	/// </summary>
	public class FileSetup2VariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FILE_TDC_SC
		/// </summary>
		public int FileTdcSc { get; }

		/// <summary>
		/// Value of variable $FILE_TV_SEC
		/// </summary>
		public int FileTvSec { get; }

		/// <summary>
		/// Value of variable $FILE_TVC_SC
		/// </summary>
		public int FileTvcSc { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
