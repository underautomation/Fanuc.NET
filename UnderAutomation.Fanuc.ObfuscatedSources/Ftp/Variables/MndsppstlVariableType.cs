//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MNDSPPSTL_T
	/// </summary>
	public class MndsppstlVariableType : GenericVariableType, IGenericVariableType {


		public MndsppstlVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LOCTOL
		/// </summary>
		public double Loctol { get; }

		/// <summary>
		/// Value of variable $ORIENTTOL
		/// </summary>
		public double Orienttol { get; }

		/// <summary>
		/// Value of variable $EXTTOL
		/// </summary>
		public double Exttol { get; }

		/// <summary>
		/// Value of variable $ANGTOL
		/// </summary>
		public double[] Angtol { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
