//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type JCR_T
	/// </summary>
	public class JcrVariableType : GenericVariableType, IGenericVariableType {


		public JcrVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $JOG_GP
		/// </summary>
		public int JogGp { get; }

		/// <summary>
		/// Value of variable $JOG_SUBGP
		/// </summary>
		public bool JogSubgp { get; }

		/// <summary>
		/// Value of variable $JOG_DCT_NAM
		/// </summary>
		public int[] JogDctNam { get; }

		/// <summary>
		/// Value of variable $JOG_DCT_ELE
		/// </summary>
		public int[] JogDctEle { get; }

		/// <summary>
		/// Value of variable $MP_JOG
		/// </summary>
		public int MpJog { get; }

		/// <summary>
		/// Value of variable $SPJOG_MSK
		/// </summary>
		public int SpjogMsk { get; }

		/// <summary>
		/// Value of variable $IJOG_KEY
		/// </summary>
		public int IjogKey { get; }

		/// <summary>
		/// Value of variable $IJOG_STAT
		/// </summary>
		public int IjogStat { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
