//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPGL_OUT_T
	/// </summary>
	public class TpglOutVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $VIEWS
		/// </summary>
		public TpglViewVariableType[] Views { get; }

		/// <summary>
		/// Value of variable $SELECTED
		/// </summary>
		public string[] Selected { get; }

		/// <summary>
		/// Value of variable $SELPOS
		/// </summary>
		public CartesianPositionVariable[] Selpos { get; }

		/// <summary>
		/// Value of variable $PIP_XML
		/// </summary>
		public string PipXml { get; }

		/// <summary>
		/// Value of variable $NODEVIS
		/// </summary>
		public byte[] Nodevis { get; }

		/// <summary>
		/// Value of variable $MACHINES
		/// </summary>
		public TpglmachVariableType[] Machines { get; }

		/// <summary>
		/// Value of variable $RECORDEDLOC
		/// </summary>
		public ReclocVariableType[] Recordedloc { get; }

		/// <summary>
		/// Value of variable $NEXTPIPE
		/// </summary>
		public string Nextpipe { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
