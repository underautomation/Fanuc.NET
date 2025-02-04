//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FILE_BACK_T
	/// </summary>
	public class FileBackVariableType : GenericVariableType, IGenericVariableType {


		public FileBackVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FILE_NAME
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $FUNC_CODE
		/// </summary>
		public short FuncCode { get; }

		/// <summary>
		/// Value of variable $MODIFIER
		/// </summary>
		public short Modifier { get; }

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $FUNC_PTR
		/// </summary>
		public int FuncPtr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
