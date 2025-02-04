//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPGL_CAM_T
	/// </summary>
	public class TpglCamVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public string Id { get; }

		/// <summary>
		/// Value of variable $FID
		/// </summary>
		public string Fid { get; }

		/// <summary>
		/// Value of variable $GIF
		/// </summary>
		public string Gif { get; }

		/// <summary>
		/// Value of variable $NEARPLANE
		/// </summary>
		public double Nearplane { get; }

		/// <summary>
		/// Value of variable $FARPLANE
		/// </summary>
		public double Farplane { get; }

		/// <summary>
		/// Value of variable $DISTANCE
		/// </summary>
		public double Distance { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
