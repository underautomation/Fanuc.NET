//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACE_CHNL_T
	/// </summary>
	public class TraceChnlVariableType : GenericVariableType, IGenericVariableType {


		public TraceChnlVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ITEM_NUM
		/// </summary>
		public int ItemNum { get; }

		/// <summary>
		/// Value of variable $TCP_GP_NUM
		/// </summary>
		public int TcpGpNum { get; }

		/// <summary>
		/// Value of variable $VISIBLE
		/// </summary>
		public bool Visible { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Value of variable $COLOR
		/// </summary>
		public int Color { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
