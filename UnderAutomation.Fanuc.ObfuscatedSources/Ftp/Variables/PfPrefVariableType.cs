//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PF_PREF_T
	/// </summary>
	public class PfPrefVariableType : GenericVariableType, IGenericVariableType {


		public PfPrefVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $GRIDLINES
		/// </summary>
		public int Gridlines { get; }

		/// <summary>
		/// Value of variable $BARS_NUM
		/// </summary>
		public int BarsNum { get; }

		/// <summary>
		/// Value of variable $DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
