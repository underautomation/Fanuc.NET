//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type REFPOS21_T
	/// </summary>
	public class Refpos21VariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $ATPERCH
		/// </summary>
		public bool Atperch { get; }

		/// <summary>
		/// Value of variable $DOUT_TYPE
		/// </summary>
		public int DoutType { get; }

		/// <summary>
		/// Value of variable $DOUT_INDX
		/// </summary>
		public int DoutIndx { get; }

		/// <summary>
		/// Value of variable $PERCHPOS
		/// </summary>
		public double[] Perchpos { get; }

		/// <summary>
		/// Value of variable $PERCHTOL
		/// </summary>
		public double[] Perchtol { get; }

		/// <summary>
		/// Value of variable $HOMEPOS
		/// </summary>
		public bool Homepos { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
