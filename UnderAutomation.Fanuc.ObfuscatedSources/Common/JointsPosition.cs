//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Joints position in degrees
	/// </summary>
	public class JointsPosition {


		public JointsPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public JointsPosition(double j1Deg, double j2Deg, double j3Deg, double j4Deg, double j5Deg, double j6Deg, double j7Deg, double j8Deg, double j9Deg)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public JointsPosition(double j1Deg, double j2Deg, double j3Deg, double j4Deg, double j5Deg, double j6Deg)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public JointsPosition(double[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Check if joints position is near to expected joints position with a tolerance value
		/// </summary>
		public static bool IsNear(JointsPosition j1, JointsPosition j2, double degreesTolerance)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public double this[int i]
		{
			get
			{
				// Source is hidden, a Source licence is needed to access internal code...
				return default;
			}
			set
			{
				// Source is hidden, a Source licence is needed to access internal code...
			}
		}

        /// <summary>
        /// Numeric values for each joints
        /// </summary>
        public double[] Values { get; }

		/// <summary>
		/// Joint 1 in degrees
		/// </summary>
		public double J1 { get; set; }

		/// <summary>
		/// Joint 2 in degrees
		/// </summary>
		public double J2 { get; set; }

		/// <summary>
		/// Joint 3 in degrees
		/// </summary>
		public double J3 { get; set; }

		/// <summary>
		/// Joint 4 in degrees
		/// </summary>
		public double J4 { get; set; }

		/// <summary>
		/// Joint 5 in degrees
		/// </summary>
		public double J5 { get; set; }

		/// <summary>
		/// Joint 6 in degrees
		/// </summary>
		public double J6 { get; set; }

		/// <summary>
		/// Joint 7 in degrees
		/// </summary>
		public double J7 { get; set; }

		/// <summary>
		/// Joint 8 in degrees
		/// </summary>
		public double J8 { get; set; }

		/// <summary>
		/// Joint 9 in degrees
		/// </summary>
		public double J9 { get; set; }
	}
}
