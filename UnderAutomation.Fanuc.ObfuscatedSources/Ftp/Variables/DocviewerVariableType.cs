//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DOCVIEWER_T
	/// </summary>
	public class DocviewerVariableType : GenericVariableType, IGenericVariableType {


		public DocviewerVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $CURFILE
		/// </summary>
		public string[] Curfile { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
