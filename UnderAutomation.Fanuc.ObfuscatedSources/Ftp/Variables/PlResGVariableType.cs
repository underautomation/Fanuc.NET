//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PL_RES_G_T
	/// </summary>
	public class PlResGVariableType : GenericVariableType, IGenericVariableType {


		public PlResGVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $SAVMOMENT4
		/// </summary>
		public double Savmoment4 { get; }

		/// <summary>
		/// Value of variable $SAVMOMENT5
		/// </summary>
		public double Savmoment5 { get; }

		/// <summary>
		/// Value of variable $SAVMOMENT6
		/// </summary>
		public double Savmoment6 { get; }

		/// <summary>
		/// Value of variable $SAVINERTIA4
		/// </summary>
		public double Savinertia4 { get; }

		/// <summary>
		/// Value of variable $SAVINERTIA5
		/// </summary>
		public double Savinertia5 { get; }

		/// <summary>
		/// Value of variable $SAVINERTIA6
		/// </summary>
		public double Savinertia6 { get; }

		/// <summary>
		/// Value of variable $EST_RESULT
		/// </summary>
		public int EstResult { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
