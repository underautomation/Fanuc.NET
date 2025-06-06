//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USER_UFRAM_T
	/// </summary>
	public class UserUframVariableType : GenericVariableType, IGenericVariableType {


		public UserUframVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $X
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Value of variable $Y
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Value of variable $Z
		/// </summary>
		public double Z { get; }

		/// <summary>
		/// Value of variable $W
		/// </summary>
		public double W { get; }

		/// <summary>
		/// Value of variable $P
		/// </summary>
		public double P { get; }

		/// <summary>
		/// Value of variable $R
		/// </summary>
		public double R { get; }

		/// <summary>
		/// Value of variable $UFRAME_NUM
		/// </summary>
		public int UframeNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
