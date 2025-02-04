//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file irc_stlabel.va
	/// </summary>
	public class IrcStlabelFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable ATTACH_FILES
		/// </summary>
		public string[] AttachFiles { get; }

		/// <summary>
		/// Value of variable CUR_TIME
		/// </summary>
		public int CurTime { get; }

		/// <summary>
		/// Value of variable CUR_TIME_STR
		/// </summary>
		public string CurTimeStr { get; }

		/// <summary>
		/// Value of variable DBG_RC
		/// </summary>
		public bool DbgRc { get; }

		/// <summary>
		/// Value of variable FILE_NAME
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Value of variable IRC_GNRC
		/// </summary>
		public IrcGnrcVariableType IrcGnrc { get; }

		/// <summary>
		/// Value of variable PKRCXMLFILE
		/// </summary>
		public string Pkrcxmlfile { get; }

		/// <summary>
		/// Value of variable SEND_EMAIL
		/// </summary>
		public bool SendEmail { get; }

		/// <summary>
		/// Value of variable SND_PRIORITY
		/// </summary>
		public int SndPriority { get; }

		/// <summary>
		/// Value of variable STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable THR_DURATION
		/// </summary>
		public int ThrDuration { get; }

		/// <summary>
		/// Value of variable THR_PRVTIME
		/// </summary>
		public int ThrPrvtime { get; }

		/// <summary>
		/// Value of variable TPP_GENCALL
		/// </summary>
		public bool TppGencall { get; }
	}
}
