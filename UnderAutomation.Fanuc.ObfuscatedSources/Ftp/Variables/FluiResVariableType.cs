//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FLUI_RES_T
	/// </summary>
	public class FluiResVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NAVID
		/// </summary>
		public string Navid { get; }

		/// <summary>
		/// Value of variable $TEXT
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Value of variable $RESULT_TYPE
		/// </summary>
		public short ResultType { get; }

		/// <summary>
		/// Value of variable $VISITED
		/// </summary>
		public short Visited { get; }

		/// <summary>
		/// Value of variable $SCID
		/// </summary>
		public int Scid { get; }

		/// <summary>
		/// Value of variable $SELECT_MASK
		/// </summary>
		public int SelectMask { get; }

		/// <summary>
		/// Value of variable $VECTOR
		/// </summary>
		public VectorVariable Vector { get; }

		/// <summary>
		/// Value of variable $NUMBER
		/// </summary>
		public int Number { get; }

		/// <summary>
		/// Value of variable $REAL_NUMBER
		/// </summary>
		public double RealNumber { get; }

		/// <summary>
		/// Value of variable $POSITION
		/// </summary>
		public CartesianPositionVariable Position { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
