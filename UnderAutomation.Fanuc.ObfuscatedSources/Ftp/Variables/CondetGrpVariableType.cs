//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_GRP_T
	/// </summary>
	public class CondetGrpVariableType : GenericVariableType, IGenericVariableType {


		public CondetGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public int Flag { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
