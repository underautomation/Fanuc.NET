//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type INTERACT_T
	/// </summary>
	public class InteractVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $INTERACTION
		/// </summary>
		public double[] Interaction { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
