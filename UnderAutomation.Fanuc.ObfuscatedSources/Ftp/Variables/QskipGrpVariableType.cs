//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type QSKIP_GRP_T
	/// </summary>
	public class QskipGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ERROR_CNT2
		/// </summary>
		public int[] ErrorCnt2 { get; }

		/// <summary>
		/// Value of variable $QSKP_ERRCNT
		/// </summary>
		public int[] QskpErrcnt { get; }

		/// <summary>
		/// Value of variable $QSKP_CURANG
		/// </summary>
		public double QskpCurang { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN1
		/// </summary>
		public double QskpCuran1 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN2
		/// </summary>
		public double QskpCuran2 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN3
		/// </summary>
		public double QskpCuran3 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN4
		/// </summary>
		public double QskpCuran4 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN5
		/// </summary>
		public double QskpCuran5 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN6
		/// </summary>
		public double QskpCuran6 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN7
		/// </summary>
		public double QskpCuran7 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN8
		/// </summary>
		public double QskpCuran8 { get; }

		/// <summary>
		/// Value of variable $QSKP_CURAN9
		/// </summary>
		public double QskpCuran9 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
