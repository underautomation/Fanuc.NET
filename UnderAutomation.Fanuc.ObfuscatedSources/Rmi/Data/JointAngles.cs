//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Joint angle set. Unused joints default to 0 if the robot has fewer than 9 axes.
	/// </summary>
	public class JointAngles {


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


		public JointAngles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Joint 1 angle.
		/// </summary>
		public double J1 { get; set; }

		/// <summary>
		/// Joint 2 angle.
		/// </summary>
		public double J2 { get; set; }

		/// <summary>
		/// Joint 3 angle.
		/// </summary>
		public double J3 { get; set; }

		/// <summary>
		/// Joint 4 angle.
		/// </summary>
		public double J4 { get; set; }

		/// <summary>
		/// Joint 5 angle.
		/// </summary>
		public double J5 { get; set; }

		/// <summary>
		/// Joint 6 angle.
		/// </summary>
		public double J6 { get; set; }

		/// <summary>
		/// Joint 7 angle (optional extended axis).
		/// </summary>
		public double J7 { get; set; }

		/// <summary>
		/// Joint 8 angle (optional extended axis).
		/// </summary>
		public double J8 { get; set; }

		/// <summary>
		/// Joint 9 angle (optional extended axis).
		/// </summary>
		public double J9 { get; set; }
	}
}
