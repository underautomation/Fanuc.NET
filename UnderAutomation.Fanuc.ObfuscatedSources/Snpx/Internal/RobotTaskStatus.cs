//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {

	public class RobotTaskStatus : IEquatable<RobotTaskStatus> {


		public string ProgramName { get; set; }


		public short LineNumber { get; set; }


		public RobotTaskState State { get; set; }


		public string Caller { get; set; }


		public bool Equals(RobotTaskStatus other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static RobotTaskStatus FromBytes(byte[] bytes, int start = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
