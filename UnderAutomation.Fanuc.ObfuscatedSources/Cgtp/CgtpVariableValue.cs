//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Cgtp {
	/// <summary>
	/// Represents the value of a controller variable with its data type.
	/// </summary>
	public class CgtpVariableValue {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Data type of the variable
		/// </summary>
		public CgtpVariableType Type { get; }

		/// <summary>
		/// Raw string value of the variable
		/// </summary>
		public string StringValue { get; }

		/// <summary>
		/// Maximum string length if the variable type is String
		/// </summary>
		public int StringLength { get; }

		/// <summary>
		/// Value interpreted as a Cartesian position.
		/// </summary>
		public CartesianPositionVariable CartesianPositionValue { get; }

		/// <summary>
		/// Value interpreted as a joint position.
		/// </summary>
		public JointPositionVariable JointPositionValue { get; }

		/// <summary>
		/// Value interpreted as an integer.
		/// </summary>
		public int IntegerValue { get; }

		/// <summary>
		/// Value interpreted as a double-precision floating-point number.
		/// </summary>
		public double RealValue { get; }

		/// <summary>
		/// Value interpreted as a boolean (TRUE/FALSE).
		/// </summary>
		public bool BooleanValue { get; }

		/// <summary>
		/// Value interpreted as a 3D vector.
		/// </summary>
		public VectorVariable VectorValue { get; }

		/// <summary>
		/// Value interpreted as a robot configuration.
		/// </summary>
		public Configuration ConfigurationValue { get; }
	}
}
