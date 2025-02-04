//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AX_OFS_T
	/// </summary>
	public class AxOfsVariableType : GenericVariableType, IGenericVariableType {


		public AxOfsVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $X
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Value of variable $Y
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Value of variable $Z
		/// </summary>
		public double Z { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
