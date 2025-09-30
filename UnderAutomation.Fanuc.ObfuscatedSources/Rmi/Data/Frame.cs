//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Cartesian frame representation: position (X/Y/Z in mm) and orientation (W/P/R in degrees).
	/// Extended axes Ext1..Ext3 are optional and default to 0.
	/// </summary>
	public class Frame {


		public Frame()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// X coordinate in millimeters.
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y coordinate in millimeters.
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z coordinate in millimeters.
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// W (Yaw) in degrees.
		/// </summary>
		public double W { get; set; }

		/// <summary>
		/// P (Pitch) in degrees.
		/// </summary>
		public double P { get; set; }

		/// <summary>
		/// R (Roll) in degrees.
		/// </summary>
		public double R { get; set; }

		/// <summary>
		/// Extended axis 1 (optional).
		/// </summary>
		public double Ext1 { get; set; }

		/// <summary>
		/// Extended axis 2 (optional).
		/// </summary>
		public double Ext2 { get; set; }

		/// <summary>
		/// Extended axis 3 (optional).
		/// </summary>
		public double Ext3 { get; set; }
	}
}
