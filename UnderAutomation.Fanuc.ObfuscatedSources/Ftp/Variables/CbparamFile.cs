//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file cbparam.va
	/// </summary>
	public class CbparamFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable PAYLOAD1
		/// </summary>
		public double Payload1 { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_X
		/// </summary>
		public double Payload1X { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_Y
		/// </summary>
		public double Payload1Y { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_Z
		/// </summary>
		public double Payload1Z { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_IX
		/// </summary>
		public double Payload1Ix { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_IY
		/// </summary>
		public double Payload1Iy { get; }

		/// <summary>
		/// Value of variable PAYLOAD1_IZ
		/// </summary>
		public double Payload1Iz { get; }

		/// <summary>
		/// Value of variable PAYLOAD2
		/// </summary>
		public double Payload2 { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_X
		/// </summary>
		public double Payload2X { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_Y
		/// </summary>
		public double Payload2Y { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_Z
		/// </summary>
		public double Payload2Z { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_IX
		/// </summary>
		public double Payload2Ix { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_IY
		/// </summary>
		public double Payload2Iy { get; }

		/// <summary>
		/// Value of variable PAYLOAD2_IZ
		/// </summary>
		public double Payload2Iz { get; }

		/// <summary>
		/// Value of variable TFRAME_X
		/// </summary>
		public double[] TframeX { get; }

		/// <summary>
		/// Value of variable TFRAME_Y
		/// </summary>
		public double[] TframeY { get; }

		/// <summary>
		/// Value of variable TFRAME_Z
		/// </summary>
		public double[] TframeZ { get; }

		/// <summary>
		/// Value of variable SE_CTRLMODE
		/// </summary>
		public int SeCtrlmode { get; }

		/// <summary>
		/// Value of variable DATA_C1
		/// </summary>
		public double[] DataC1 { get; }

		/// <summary>
		/// Value of variable DATA_C2
		/// </summary>
		public double[] DataC2 { get; }

		/// <summary>
		/// Value of variable DATA_C3
		/// </summary>
		public double[] DataC3 { get; }

		/// <summary>
		/// Value of variable DATA_C4
		/// </summary>
		public double[] DataC4 { get; }

		/// <summary>
		/// Value of variable DATA_C5
		/// </summary>
		public double[] DataC5 { get; }

		/// <summary>
		/// Value of variable DATA_C6
		/// </summary>
		public double[] DataC6 { get; }

		/// <summary>
		/// Value of variable DATA_C7
		/// </summary>
		public double[] DataC7 { get; }

		/// <summary>
		/// Value of variable DATA_C8
		/// </summary>
		public double[] DataC8 { get; }

		/// <summary>
		/// Value of variable DATA_C9
		/// </summary>
		public double[] DataC9 { get; }

		/// <summary>
		/// Value of variable DATA_C10
		/// </summary>
		public double[] DataC10 { get; }
	}
}
