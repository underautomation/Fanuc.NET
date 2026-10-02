//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Geometry {
	/// <summary>
	/// Position of the axes of a robot: one value per axis, in degrees for rotary axes and in mm for linear axes
	/// </summary>
	public class JointValues {

		/// <summary>
		/// Creates a joint position from the values of the axes. The array is copied.
		/// </summary>
		/// <param name="values">Value of each axis</param>
		public JointValues(params double[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Value of each axis, in degrees or mm
		/// </summary>
		public double[] Values { get; }

		/// <summary>
		/// Number of axes
		/// </summary>
		public int Count { get; }
	}
}
