//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Cgtp.BatchVariables {
	/// <summary>
	/// Represents a generic controller variable for batch read/write operations.
	/// Supports scalar values (integer, real, boolean, string, position, vector, configuration)
	/// and structured values (FIELD/ARRAY hierarchies).
	/// </summary>
	public class CgtpVariable : ICgtpBatchVariable {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Full variable name (e.g. "$NUMREG[1]", "$POSREG[1,2]", "$RMT_MASTER")
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Program name that owns this variable
		/// </summary>
		public string Program { get; }


		public string StringValue { get; set; }

		/// <summary>
		/// Indicates whether a value was returned by the controller during a batch read.
		/// False if the variable was not found.
		/// </summary>
		public bool Exists { get; }

		/// <summary>
		/// Indicates whether the variable is uninitialized on the controller
		/// </summary>
		public bool IsUninitialized { get; }

		/// <summary>
		/// Indicates whether the variable is read-only on the controller and cannot be written with CGTP
		/// </summary>
		public bool IsReadOnly { get; }

		/// <summary>
		/// Structured value returned for complex variables (with FIELD/ARRAY children).
		/// Null for scalar variables.
		/// When writing, if this is not null each leaf field is written independently.
		/// </summary>
		public CgtpStructureField StructureValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a Cartesian position.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public CartesianPositionVariable CartesianPositionValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a joint position.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public JointPositionVariable JointPositionValue { get; set; }

		/// <summary>
		/// Gets or sets the value as an integer.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public int IntegerValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a double.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public double RealValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a boolean.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public bool BooleanValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a 3D vector.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public VectorVariable VectorValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a robot configuration.
		/// Setting this property updates <xref href="UnderAutomation.Fanuc.Cgtp.BatchVariables.CgtpVariable.StringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public Configuration ConfigurationValue { get; set; }
	}
}
