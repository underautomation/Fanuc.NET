//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SSR_T
	/// </summary>
	public class SsrVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SINGLESTEP
		/// </summary>
		public byte Singlestep { get; }

		/// <summary>
		/// Value of variable $DUMMY8
		/// </summary>
		public byte Dummy8 { get; }

		/// <summary>
		/// Value of variable $SGLSTEPTASK
		/// </summary>
		public byte[] Sglsteptask { get; }

		/// <summary>
		/// Value of variable $STEPTASKNUM
		/// </summary>
		public byte Steptasknum { get; }

		/// <summary>
		/// Value of variable $STEPSTMTTYP
		/// </summary>
		public byte Stepstmttyp { get; }

		/// <summary>
		/// Value of variable $STPSEGTYPE
		/// </summary>
		public byte Stpsegtype { get; }

		/// <summary>
		/// Value of variable $BWDSTEP
		/// </summary>
		public byte Bwdstep { get; }

		/// <summary>
		/// Value of variable $SHOWSTMTTYP
		/// </summary>
		public int Showstmttyp { get; }

		/// <summary>
		/// Value of variable $BANSTPTPOFF
		/// </summary>
		public byte Banstptpoff { get; }

		/// <summary>
		/// Value of variable $DUMMY9
		/// </summary>
		public byte Dummy9 { get; }

		/// <summary>
		/// Value of variable $DUMMY10
		/// </summary>
		public byte Dummy10 { get; }

		/// <summary>
		/// Value of variable $DUMMY11
		/// </summary>
		public byte Dummy11 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
