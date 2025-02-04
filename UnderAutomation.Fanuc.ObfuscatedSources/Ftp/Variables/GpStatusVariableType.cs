//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GP_STATUS_T
	/// </summary>
	public class GpStatusVariableType : GenericVariableType, IGenericVariableType {


		public GpStatusVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $IN_USE
		/// </summary>
		public bool InUse { get; }

		/// <summary>
		/// Value of variable $SPACE_NUM
		/// </summary>
		public int SpaceNum { get; }

		/// <summary>
		/// Value of variable $PRIORITY
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Value of variable $STATUS1
		/// </summary>
		public int Status1 { get; }

		/// <summary>
		/// Value of variable $STATUS2
		/// </summary>
		public int Status2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
