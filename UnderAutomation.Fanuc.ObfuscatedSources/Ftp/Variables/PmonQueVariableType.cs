//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PMON_QUE_T
	/// </summary>
	public class PmonQueVariableType : GenericVariableType, IGenericVariableType {


		public PmonQueVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $QCOUNT
		/// </summary>
		public int Qcount { get; }

		/// <summary>
		/// Value of variable $QTHRESHOLD
		/// </summary>
		public int Qthreshold { get; }

		/// <summary>
		/// Value of variable $QHYSTERESIS
		/// </summary>
		public int Qhysteresis { get; }

		/// <summary>
		/// Value of variable $QUEUE_UP
		/// </summary>
		public bool QueueUp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
