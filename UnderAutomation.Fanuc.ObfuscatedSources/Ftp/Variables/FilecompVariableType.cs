//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FILECOMP_T
	/// </summary>
	public class FilecompVariableType : GenericVariableType, IGenericVariableType {


		public FilecompVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TPP
		/// </summary>
		public bool Tpp { get; }

		/// <summary>
		/// Value of variable $VARIABLE
		/// </summary>
		public bool Variable { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
