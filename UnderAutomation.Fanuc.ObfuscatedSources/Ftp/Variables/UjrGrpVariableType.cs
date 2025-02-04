//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UJR_GRP_T
	/// </summary>
	public class UjrGrpVariableType : GenericVariableType, IGenericVariableType {


		public UjrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FINE_OVRD
		/// </summary>
		public int FineOvrd { get; }

		/// <summary>
		/// Value of variable $JOGFRAME
		/// </summary>
		public CartesianPositionVariable Jogframe { get; }

		/// <summary>
		/// Value of variable $FINE_DIST
		/// </summary>
		public double FineDist { get; }

		/// <summary>
		/// Value of variable $J7_GROUP
		/// </summary>
		public short J7Group { get; }

		/// <summary>
		/// Value of variable $J8_GROUP
		/// </summary>
		public short J8Group { get; }

		/// <summary>
		/// Value of variable $J7_AXIS
		/// </summary>
		public short J7Axis { get; }

		/// <summary>
		/// Value of variable $J8_AXIS
		/// </summary>
		public short J8Axis { get; }

		/// <summary>
		/// Value of variable $J7_LABEL
		/// </summary>
		public string J7Label { get; }

		/// <summary>
		/// Value of variable $J8_LABEL
		/// </summary>
		public string J8Label { get; }

		/// <summary>
		/// Value of variable $J7_GRAPHIC
		/// </summary>
		public string J7Graphic { get; }

		/// <summary>
		/// Value of variable $J8_GRAPHIC
		/// </summary>
		public string J8Graphic { get; }

		/// <summary>
		/// Value of variable $DSB_J7J8
		/// </summary>
		public bool DsbJ7j8 { get; }

		/// <summary>
		/// Value of variable $DSBL_KEY
		/// </summary>
		public bool[] DsblKey { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
