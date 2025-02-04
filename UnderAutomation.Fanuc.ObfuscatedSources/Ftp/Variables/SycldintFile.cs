//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sycldint.va
	/// </summary>
	public class SycldintFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SycldintFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ERSEVERITY
		/// </summary>
		public int Erseverity { get; }

		/// <summary>
		/// Value of variable $JCR
		/// </summary>
		public JcrVariableType Jcr { get; }

		/// <summary>
		/// Value of variable $JCR_GRP
		/// </summary>
		public JcrGrpVariableType[] JcrGrp { get; }

		/// <summary>
		/// Value of variable $LOAD_DEVICE
		/// </summary>
		public string LoadDevice { get; }

		/// <summary>
		/// Value of variable $MCR
		/// </summary>
		public McrVariableType Mcr { get; }

		/// <summary>
		/// Value of variable $MCR_GRP
		/// </summary>
		public McrGrpVariableType[] McrGrp { get; }

		/// <summary>
		/// Value of variable $MOR
		/// </summary>
		public MorVariableType Mor { get; }

		/// <summary>
		/// Value of variable $MOR_GRP
		/// </summary>
		public MorGrpVariableType[] MorGrp { get; }

		/// <summary>
		/// Value of variable $PWR_UP_RTN
		/// </summary>
		public string[] PwrUpRtn { get; }

		/// <summary>
		/// Value of variable $TPABRT_USED
		/// </summary>
		public bool TpabrtUsed { get; }
	}
}
