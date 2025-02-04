//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file syshost.va
	/// </summary>
	public class SyshostFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $BIN_CFG
		/// </summary>
		public BinCfgVariableType BinCfg { get; }

		/// <summary>
		/// Value of variable $DHCP_CTRL
		/// </summary>
		public DhcpCtrlVariableType[] DhcpCtrl { get; }

		/// <summary>
		/// Value of variable $DNSS_CFG
		/// </summary>
		public DnssCfgVariableType DnssCfg { get; }

		/// <summary>
		/// Value of variable $DNS_CFG
		/// </summary>
		public DnsCfgVariableType DnsCfg { get; }

		/// <summary>
		/// Value of variable $DNS_LOC_DOM
		/// </summary>
		public byte[] DnsLocDom { get; }

		/// <summary>
		/// Value of variable $ETH_FLTR
		/// </summary>
		public int[] EthFltr { get; }

		/// <summary>
		/// Value of variable $FTP_CTRL
		/// </summary>
		public FtpCtrlVariableType FtpCtrl { get; }

		/// <summary>
		/// Value of variable $HOST_SHARED
		/// </summary>
		public HostentVariableType[] HostShared { get; }

		/// <summary>
		/// Value of variable $PPP_LIST
		/// </summary>
		public PppcfgLstVariableType[] PppList { get; }

		/// <summary>
		/// Value of variable $RCMCFG
		/// </summary>
		public RcmcfgVariableType Rcmcfg { get; }

		/// <summary>
		/// Value of variable $RDM_CFG
		/// </summary>
		public RdmCfgVariableType RdmCfg { get; }

		/// <summary>
		/// Value of variable $SMB
		/// </summary>
		public SmbVariableType Smb { get; }

		/// <summary>
		/// Value of variable $SMB_CLNT
		/// </summary>
		public SmbClntVariableType[] SmbClnt { get; }

		/// <summary>
		/// Value of variable $SMTP_CTRL
		/// </summary>
		public SmtpCtrlVariableType SmtpCtrl { get; }

		/// <summary>
		/// Value of variable $SNTP_CFG
		/// </summary>
		public SntpCfgVariableType SntpCfg { get; }

		/// <summary>
		/// Value of variable $SNTP_CUSTOM
		/// </summary>
		public SntpCustomVariableType SntpCustom { get; }

		/// <summary>
		/// Value of variable $TCPIPCFG
		/// </summary>
		public TcpipcfgVariableType Tcpipcfg { get; }
	}
}
