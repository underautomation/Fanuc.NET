//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GLOFATT_T
	/// </summary>
	public class GlofattVariableType : GenericVariableType, IGenericVariableType {


		public GlofattVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DEVICE
		/// </summary>
		public string Device { get; }

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $EXT
		/// </summary>
		public string Ext { get; }

		/// <summary>
		/// Value of variable $TASKID
		/// </summary>
		public short Taskid { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public byte Mode { get; }

		/// <summary>
		/// Value of variable $TSKFNUM
		/// </summary>
		public byte Tskfnum { get; }

		/// <summary>
		/// Value of variable $FILEPTR
		/// </summary>
		public int Fileptr { get; }

		/// <summary>
		/// Value of variable $KFILE
		/// </summary>
		public int Kfile { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
