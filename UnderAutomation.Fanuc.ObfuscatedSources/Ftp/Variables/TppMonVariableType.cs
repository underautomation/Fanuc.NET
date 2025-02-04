//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPP_MON_T
	/// </summary>
	public class TppMonVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GLOBAL_MT
		/// </summary>
		public int GlobalMt { get; }

		/// <summary>
		/// Value of variable $LOCAL_MT
		/// </summary>
		public int LocalMt { get; }

		/// <summary>
		/// Value of variable $MON_NUM
		/// </summary>
		public int MonNum { get; }

		/// <summary>
		/// Value of variable $GMON_TID
		/// </summary>
		public int GmonTid { get; }

		/// <summary>
		/// Value of variable $SYSMON_ADR
		/// </summary>
		public int SysmonAdr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
