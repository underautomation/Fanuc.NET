//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TP_CURSCRN_T
	/// </summary>
	public class TpCurscrnVariableType : GenericVariableType, IGenericVariableType {


		public TpCurscrnVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NEST_TYPE
		/// </summary>
		public int NestType { get; }

		/// <summary>
		/// Value of variable $SP_ID
		/// </summary>
		public int SpId { get; }

		/// <summary>
		/// Value of variable $SCRN_ID
		/// </summary>
		public int ScrnId { get; }

		/// <summary>
		/// Value of variable $SID
		/// </summary>
		public int Sid { get; }

		/// <summary>
		/// Value of variable $IDX1
		/// </summary>
		public int Idx1 { get; }

		/// <summary>
		/// Value of variable $IDX2
		/// </summary>
		public int Idx2 { get; }

		/// <summary>
		/// Value of variable $IDX3
		/// </summary>
		public int Idx3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
