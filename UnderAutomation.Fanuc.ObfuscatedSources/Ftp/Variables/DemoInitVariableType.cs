//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DEMO_INIT_T
	/// </summary>
	public class DemoInitVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DEMO_ENB
		/// </summary>
		public bool DemoEnb { get; }

		/// <summary>
		/// Value of variable $DEMO_AU
		/// </summary>
		public bool DemoAu { get; }

		/// <summary>
		/// Value of variable $DEMO_DAYS
		/// </summary>
		public int DemoDays { get; }

		/// <summary>
		/// Value of variable $LOAD_NUM
		/// </summary>
		public short LoadNum { get; }

		/// <summary>
		/// Value of variable $DUMMY4
		/// </summary>
		public byte Dummy4 { get; }

		/// <summary>
		/// Value of variable $DUMMY5
		/// </summary>
		public byte Dummy5 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
