//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IRC_GNRC_T
	/// </summary>
	public class IrcGnrcVariableType : GenericVariableType, IGenericVariableType {


		public IrcGnrcVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable DOSTIME
		/// </summary>
		public int Dostime { get; }

		/// <summary>
		/// Value of variable MSGTYPE
		/// </summary>
		public int Msgtype { get; }

		/// <summary>
		/// Value of variable INT1
		/// </summary>
		public int Int1 { get; }

		/// <summary>
		/// Value of variable INT2
		/// </summary>
		public int Int2 { get; }

		/// <summary>
		/// Value of variable STR1
		/// </summary>
		public string Str1 { get; }

		/// <summary>
		/// Value of variable STR2
		/// </summary>
		public string Str2 { get; }

		/// <summary>
		/// Value of variable STR3
		/// </summary>
		public string Str3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
