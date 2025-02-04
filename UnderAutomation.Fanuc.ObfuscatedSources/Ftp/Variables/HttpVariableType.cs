//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HTTP_T
	/// </summary>
	public class HttpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $ENAB_DIAGTP
		/// </summary>
		public int EnabDiagtp { get; }

		/// <summary>
		/// Value of variable $ENAB_SPART
		/// </summary>
		public int EnabSpart { get; }

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $KRL_TIMOUT
		/// </summary>
		public int KrlTimout { get; }

		/// <summary>
		/// Value of variable $HITCOUNT
		/// </summary>
		public int Hitcount { get; }

		/// <summary>
		/// Value of variable $BG_COLOR
		/// </summary>
		public string BgColor { get; }

		/// <summary>
		/// Value of variable $ENAB_TEMPL
		/// </summary>
		public int EnabTempl { get; }

		/// <summary>
		/// Value of variable $TEMPLATE
		/// </summary>
		public string Template { get; }

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $RSS_INUM
		/// </summary>
		public int RssInum { get; }

		/// <summary>
		/// Value of variable $JQUERY_FLAG
		/// </summary>
		public int JqueryFlag { get; }

		/// <summary>
		/// Value of variable $ENB_WEBSOCK
		/// </summary>
		public int EnbWebsock { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
