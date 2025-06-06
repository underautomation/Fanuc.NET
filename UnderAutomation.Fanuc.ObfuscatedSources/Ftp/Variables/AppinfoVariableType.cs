//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type APPINFO_T
	/// </summary>
	public class AppinfoVariableType : GenericVariableType, IGenericVariableType {


		public AppinfoVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DATA
		/// </summary>
		public int[] Data { get; }

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $EQUIP
		/// </summary>
		public AppinfoeqVariableType[] Equip { get; }

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $NAME_OVRD
		/// </summary>
		public bool NameOvrd { get; }

		/// <summary>
		/// Value of variable $VERSION
		/// </summary>
		public int Version { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
