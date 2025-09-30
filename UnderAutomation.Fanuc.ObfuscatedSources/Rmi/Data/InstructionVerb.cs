//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Instruction verbs that append to the TP program.
	/// </summary>
	public enum InstructionVerb {

		/// <summary>
		/// WAIT DI[x] = ON/OFF.
		/// </summary>
		FRC_WaitDin = 0,

		/// <summary>
		/// UFRAME_NUM = n.
		/// </summary>
		FRC_SetUFrame = 1,

		/// <summary>
		/// UTOOL_NUM = n.
		/// </summary>
		FRC_SetUTool = 2,

		/// <summary>
		/// WAIT t (sec).
		/// </summary>
		FRC_Wait = 3,

		/// <summary>
		/// PAYLOAD[n].
		/// </summary>
		FRC_PayLoad = 4,

		/// <summary>
		/// Linear motion in Cartesian representation.
		/// </summary>
		FRC_LinearMotion = 5,

		/// <summary>
		/// Linear incremental motion in Cartesian representation.
		/// </summary>
		FRC_LinearRelative = 6,

		/// <summary>
		/// Joint motion in Cartesian representation.
		/// </summary>
		FRC_JointMotion = 7,

		/// <summary>
		/// Joint incremental motion in Cartesian representation.
		/// </summary>
		FRC_JointRelative = 8,

		/// <summary>
		/// Circular motion in Cartesian representation.
		/// </summary>
		FRC_CircularMotion = 9,

		/// <summary>
		/// Circular incremental motion in Cartesian representation.
		/// </summary>
		FRC_CircularRelative = 10,

		/// <summary>
		/// Joint motion specified by joint angles.
		/// </summary>
		FRC_JointMotionJRep = 11,

		/// <summary>
		/// Joint incremental motion specified by joint angles.
		/// </summary>
		FRC_JointRelativeJRep = 12,

		/// <summary>
		/// Linear motion specified by joint angles.
		/// </summary>
		FRC_LinearMotionJRep = 13,

		/// <summary>
		/// Linear incremental motion specified by joint angles.
		/// </summary>
		FRC_LinearRelativeJRep = 14,
	}
}
