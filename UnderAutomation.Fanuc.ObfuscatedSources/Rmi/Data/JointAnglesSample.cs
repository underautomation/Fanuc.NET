//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading joint angles.
	/// </summary>
	public class JointAnglesSample : RmiTimedResponse {


		public JointAnglesSample()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Joint angle set.
		/// </summary>
		public JointAngles JointAngle { get; set; }
	}
}
