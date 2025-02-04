//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MOTION_DBG_T
	/// </summary>
	public class MotionDbgVariableType : GenericVariableType, IGenericVariableType {


		public MotionDbgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $OUTPUT
		/// </summary>
		public bool Output { get; }

		/// <summary>
		/// Value of variable $MGDEBUG
		/// </summary>
		public MgdebugVariableType Mgdebug { get; }

		/// <summary>
		/// Value of variable $MIDEBUG
		/// </summary>
		public MgdebugVariableType Midebug { get; }

		/// <summary>
		/// Value of variable $MPDEBUG
		/// </summary>
		public MgdebugVariableType Mpdebug { get; }

		/// <summary>
		/// Value of variable $MIDEBUG_ITP
		/// </summary>
		public MgdebugVariableType MidebugItp { get; }

		/// <summary>
		/// Value of variable $PGDEBUG
		/// </summary>
		public MgdebugVariableType Pgdebug { get; }

		/// <summary>
		/// Value of variable $KEEP
		/// </summary>
		public bool Keep { get; }

		/// <summary>
		/// Value of variable $PATH
		/// </summary>
		public string Path { get; }

		/// <summary>
		/// Value of variable $BIN_OUTPUT
		/// </summary>
		public int BinOutput { get; }

		/// <summary>
		/// Value of variable $SND2SERVER
		/// </summary>
		public bool Snd2server { get; }

		/// <summary>
		/// Value of variable $BIN_2_TXT
		/// </summary>
		public int Bin2Txt { get; }

		/// <summary>
		/// Value of variable $EXTRA1
		/// </summary>
		public int Extra1 { get; }

		/// <summary>
		/// Value of variable $EXTRA2
		/// </summary>
		public int Extra2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
