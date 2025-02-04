//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBCSG_GRP_T
	/// </summary>
	public class TbcsgGrpVariableType : GenericVariableType, IGenericVariableType {


		public TbcsgGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $APPRC_SCL
		/// </summary>
		public double[] ApprcScl { get; }

		/// <summary>
		/// Value of variable $OPEN_SCL
		/// </summary>
		public double[] OpenScl { get; }

		/// <summary>
		/// Value of variable $CLOSE_SCL
		/// </summary>
		public double[] CloseScl { get; }

		/// <summary>
		/// Value of variable $CLS_MINF2
		/// </summary>
		public double[] ClsMinf2 { get; }

		/// <summary>
		/// Value of variable $CLS_MINACC
		/// </summary>
		public double[] ClsMinacc { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
