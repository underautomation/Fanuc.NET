//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_FKEYDAT_T
	/// </summary>
	public class UiFkeydatVariableType : GenericVariableType, IGenericVariableType {


		public UiFkeydatVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENB_COLOR
		/// </summary>
		public byte[] EnbColor { get; }

		/// <summary>
		/// Value of variable $PS_BACKCOLO
		/// </summary>
		public short PsBackcolo { get; }

		/// <summary>
		/// Value of variable $BACKCOLOR
		/// </summary>
		public int[] Backcolor { get; }

		/// <summary>
		/// Value of variable $FORECOLOR
		/// </summary>
		public int[] Forecolor { get; }

		/// <summary>
		/// Value of variable $LABEL
		/// </summary>
		public string[] Label { get; }

		/// <summary>
		/// Value of variable $ICON
		/// </summary>
		public string[] Icon { get; }

		/// <summary>
		/// Value of variable $URL
		/// </summary>
		public string[] Url { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
