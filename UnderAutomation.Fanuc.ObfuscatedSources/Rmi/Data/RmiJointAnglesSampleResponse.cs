//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.Data {
	/// <summary>
	/// Result of reading the current joint angles.
	/// </summary>
	public class RmiJointAnglesSampleResponse : RmiTimedResponse {


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


		public RmiJointAnglesSampleResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Joint angle set in degrees.
		/// </summary>
		public JointsPosition JointAngle { get; set; }
	}
}
