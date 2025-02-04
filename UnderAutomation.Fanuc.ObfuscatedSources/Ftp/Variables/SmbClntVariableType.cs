//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SMB_CLNT_T
	/// </summary>
	public class SmbClntVariableType : GenericVariableType, IGenericVariableType {


		public SmbClntVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CACHE
		/// </summary>
		public bool Cache { get; }

		/// <summary>
		/// Value of variable $RSPTMOUT
		/// </summary>
		public int Rsptmout { get; }

		/// <summary>
		/// Value of variable $SETPWRD
		/// </summary>
		public bool Setpwrd { get; }

		/// <summary>
		/// Value of variable $DOMAIN
		/// </summary>
		public string Domain { get; }

		/// <summary>
		/// Value of variable $SPARE
		/// </summary>
		public int Spare { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
