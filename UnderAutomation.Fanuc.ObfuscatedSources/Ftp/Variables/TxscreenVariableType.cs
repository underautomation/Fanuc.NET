//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TXSCREEN_T
	/// </summary>
	public class TxscreenVariableType : GenericVariableType, IGenericVariableType {


		public TxscreenVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DESTINATION
		/// </summary>
		public string Destination { get; }

		/// <summary>
		/// Value of variable $SCREEN_NAME
		/// </summary>
		public string ScreenName { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
