//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PF_DATA_T
	/// </summary>
	public class PfDataVariableType : GenericVariableType, IGenericVariableType {


		public PfDataVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $VALUE
		/// </summary>
		public double Value { get; }

		/// <summary>
		/// Value of variable $GROUP
		/// </summary>
		public int Group { get; }

		/// <summary>
		/// Value of variable $AXIS
		/// </summary>
		public int Axis { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
