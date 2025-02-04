//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPGL_MSET_T
	/// </summary>
	public class TpglMsetVariableType : GenericVariableType, IGenericVariableType {


		public TpglMsetVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public string Id { get; }

		/// <summary>
		/// Value of variable $TIMECONST
		/// </summary>
		public int Timeconst { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
