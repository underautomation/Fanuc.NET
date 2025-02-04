//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DBINFO_T
	/// </summary>
	public class DbinfoVariableType : GenericVariableType, IGenericVariableType {


		public DbinfoVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DAT_AD
		/// </summary>
		public int DatAd { get; }

		/// <summary>
		/// Value of variable $MLB
		/// </summary>
		public int Mlb { get; }

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Value of variable $TID
		/// </summary>
		public int Tid { get; }

		/// <summary>
		/// Value of variable $XF
		/// </summary>
		public XfVariableType Xf { get; }

		/// <summary>
		/// Value of variable $UXF
		/// </summary>
		public XfVariableType Uxf { get; }

		/// <summary>
		/// Value of variable $R_XF
		/// </summary>
		public XfVariableType RXf { get; }

		/// <summary>
		/// Value of variable $DPOS
		/// </summary>
		public XYZPosition Dpos { get; }

		/// <summary>
		/// Value of variable $LOC
		/// </summary>
		public XYZPosition Loc { get; }

		/// <summary>
		/// Value of variable $LINE
		/// </summary>
		public int Line { get; }

		/// <summary>
		/// Value of variable $EPT
		/// </summary>
		public int Ept { get; }

		/// <summary>
		/// Value of variable $CND
		/// </summary>
		public int Cnd { get; }

		/// <summary>
		/// Value of variable $PRGDAT
		/// </summary>
		public int Prgdat { get; }

		/// <summary>
		/// Value of variable $OFFSET
		/// </summary>
		public XYZPosition Offset { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
