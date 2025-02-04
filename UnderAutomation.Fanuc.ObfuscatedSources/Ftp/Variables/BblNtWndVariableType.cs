//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type BBL_NT_WND_T
	/// </summary>
	public class BblNtWndVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $WND_TOP
		/// </summary>
		public short WndTop { get; }

		/// <summary>
		/// Value of variable $WND_LEFT
		/// </summary>
		public short WndLeft { get; }

		/// <summary>
		/// Value of variable $WND_BOTTOM
		/// </summary>
		public short WndBottom { get; }

		/// <summary>
		/// Value of variable $WND_RIGHT
		/// </summary>
		public short WndRight { get; }

		/// <summary>
		/// Value of variable $BRDR_CLR
		/// </summary>
		public int BrdrClr { get; }

		/// <summary>
		/// Value of variable $BCKGRND_CLR
		/// </summary>
		public int BckgrndClr { get; }

		/// <summary>
		/// Value of variable $TEXT_CLR
		/// </summary>
		public int TextClr { get; }

		/// <summary>
		/// Value of variable $BRDR_WIDTH
		/// </summary>
		public byte BrdrWidth { get; }

		/// <summary>
		/// Value of variable $DISPTIME
		/// </summary>
		public byte Disptime { get; }

		/// <summary>
		/// Value of variable $FLAGS
		/// </summary>
		public short Flags { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
