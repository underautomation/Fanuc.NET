//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $TCOL_LINE
	/// </summary>
	public class TcolLineVariableType : GenericVariableType, IGenericVariableType {


		public TcolLineVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LINE
		/// </summary>
		public byte[] Line { get; }

		/// <summary>
		/// Value of variable $LINE_SIZE
		/// </summary>
		public int LineSize { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
