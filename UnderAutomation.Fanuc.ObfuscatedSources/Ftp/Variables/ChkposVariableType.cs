//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CHKPOS_T
	/// </summary>
	public class ChkposVariableType : GenericVariableType, IGenericVariableType {


		public ChkposVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CONT_FLAG
		/// </summary>
		public bool ContFlag { get; }

		/// <summary>
		/// Value of variable $POS_HDR
		/// </summary>
		public int PosHdr { get; }

		/// <summary>
		/// Value of variable $POS_HDR2
		/// </summary>
		public int PosHdr2 { get; }

		/// <summary>
		/// Value of variable $JPOS1
		/// </summary>
		public int Jpos1 { get; }

		/// <summary>
		/// Value of variable $JPOS2
		/// </summary>
		public int Jpos2 { get; }

		/// <summary>
		/// Value of variable $JPOS3
		/// </summary>
		public int Jpos3 { get; }

		/// <summary>
		/// Value of variable $JPOS4
		/// </summary>
		public int Jpos4 { get; }

		/// <summary>
		/// Value of variable $JPOS5
		/// </summary>
		public int Jpos5 { get; }

		/// <summary>
		/// Value of variable $JPOS6
		/// </summary>
		public int Jpos6 { get; }

		/// <summary>
		/// Value of variable $JPOS7
		/// </summary>
		public int Jpos7 { get; }

		/// <summary>
		/// Value of variable $JPOS8
		/// </summary>
		public int Jpos8 { get; }

		/// <summary>
		/// Value of variable $JPOS9
		/// </summary>
		public int Jpos9 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
