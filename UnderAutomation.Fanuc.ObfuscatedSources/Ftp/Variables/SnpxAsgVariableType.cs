//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SNPX_ASG_T
	/// </summary>
	public class SnpxAsgVariableType : GenericVariableType, IGenericVariableType {


		public SnpxAsgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ADDRESS
		/// </summary>
		public short Address { get; }

		/// <summary>
		/// Value of variable $SIZE
		/// </summary>
		public short Size { get; }

		/// <summary>
		/// Value of variable $VAR_NAME
		/// </summary>
		public string VarName { get; }

		/// <summary>
		/// Value of variable $MULTIPLY
		/// </summary>
		public double Multiply { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
