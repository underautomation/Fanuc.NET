//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type REMOTE_CFG_T
	/// </summary>
	public class RemoteCfgVariableType : GenericVariableType, IGenericVariableType {


		public RemoteCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $REMOTE_TYPE
		/// </summary>
		public int RemoteType { get; }

		/// <summary>
		/// Value of variable $REMOTEIOTYP
		/// </summary>
		public int Remoteiotyp { get; }

		/// <summary>
		/// Value of variable $REMOTEIOIDX
		/// </summary>
		public int Remoteioidx { get; }

		/// <summary>
		/// Value of variable $LOCAL_OPTYP
		/// </summary>
		public int LocalOptyp { get; }

		/// <summary>
		/// Value of variable $LOCAL_START
		/// </summary>
		public int LocalStart { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
