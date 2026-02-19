//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Motion data containing 9 axis values (joint or cartesian + extended axes)
	/// </summary>
	public class MotionData {

		/// <summary>
		/// Default constructor
		/// </summary>
		public MotionData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with initial values
		/// </summary>
		public MotionData(float[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Raw axis values (9 values: J1-J6 or X,Y,Z,W,P,R + E1,E2,E3)
		/// </summary>
		public float[] Values { get; }

		/// <summary>
		/// First axis (J1 or X)
		/// </summary>
		public float Axis1 { get; set; }

		/// <summary>
		/// Second axis (J2 or Y)
		/// </summary>
		public float Axis2 { get; set; }

		/// <summary>
		/// Third axis (J3 or Z)
		/// </summary>
		public float Axis3 { get; set; }

		/// <summary>
		/// Fourth axis (J4 or W)
		/// </summary>
		public float Axis4 { get; set; }

		/// <summary>
		/// Fifth axis (J5 or P)
		/// </summary>
		public float Axis5 { get; set; }

		/// <summary>
		/// Sixth axis (J6 or R)
		/// </summary>
		public float Axis6 { get; set; }

		/// <summary>
		/// Extended axis 1
		/// </summary>
		public float ExtAxis1 { get; set; }

		/// <summary>
		/// Extended axis 2
		/// </summary>
		public float ExtAxis2 { get; set; }

		/// <summary>
		/// Extended axis 3
		/// </summary>
		public float ExtAxis3 { get; set; }

		/// <summary>
		/// J1 (same as Axis1)
		/// </summary>
		public float J1 { get; set; }

		/// <summary>
		/// J2 (same as Axis2)
		/// </summary>
		public float J2 { get; set; }

		/// <summary>
		/// J3 (same as Axis3)
		/// </summary>
		public float J3 { get; set; }

		/// <summary>
		/// J4 (same as Axis4)
		/// </summary>
		public float J4 { get; set; }

		/// <summary>
		/// J5 (same as Axis5)
		/// </summary>
		public float J5 { get; set; }

		/// <summary>
		/// J6 (same as Axis6)
		/// </summary>
		public float J6 { get; set; }

		/// <summary>
		/// J7 (same as ExtAxis1)
		/// </summary>
		public float J7 { get; set; }

		/// <summary>
		/// J8 (same as ExtAxis2)
		/// </summary>
		public float J8 { get; set; }

		/// <summary>
		/// J9 (same as ExtAxis3)
		/// </summary>
		public float J9 { get; set; }

		/// <summary>
		/// X (same as Axis1) in mm
		/// </summary>
		public float X { get; set; }

		/// <summary>
		/// Y (same as Axis2) in mm
		/// </summary>
		public float Y { get; set; }

		/// <summary>
		/// Z (same as Axis3) in mm
		/// </summary>
		public float Z { get; set; }

		/// <summary>
		/// W (same as Axis4) in degrees
		/// </summary>
		public float W { get; set; }

		/// <summary>
		/// P (same as Axis5) in degrees
		/// </summary>
		public float P { get; set; }

		/// <summary>
		/// R (same as Axis6) in degrees
		/// </summary>
		public float R { get; set; }

		/// <summary>
		/// E1 (same as ExtAxis1)
		/// </summary>
		public float E1 { get; set; }

		/// <summary>
		/// E2 (same as ExtAxis2)
		/// </summary>
		public float E2 { get; set; }

		/// <summary>
		/// E3 (same as ExtAxis3)
		/// </summary>
		public float E3 { get; set; }
	}
}
