//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FLUI_DATA_T
	/// </summary>
	public class FluiDataVariableType : GenericVariableType, IGenericVariableType {


		public FluiDataVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FUTURE1
		/// </summary>
		public short Future1 { get; }

		/// <summary>
		/// Value of variable $FUTURE2
		/// </summary>
		public short Future2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
