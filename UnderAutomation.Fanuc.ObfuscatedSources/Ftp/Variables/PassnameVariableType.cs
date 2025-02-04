//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PASSNAME_T
	/// </summary>
	public class PassnameVariableType : GenericVariableType, IGenericVariableType {


		public PassnameVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $LEVEL
		/// </summary>
		public short Level { get; }

		/// <summary>
		/// Value of variable $TIME_OUT
		/// </summary>
		public short TimeOut { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
