//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CO_MORGRP_T
	/// </summary>
	public class CoMorgrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FLEN
		/// </summary>
		public int Flen { get; }

		/// <summary>
		/// Value of variable $ANGLE
		/// </summary>
		public double Angle { get; }

		/// <summary>
		/// Value of variable $TBA_MAG
		/// </summary>
		public double TbaMag { get; }

		/// <summary>
		/// Value of variable $TBA_MAG_PRE
		/// </summary>
		public double TbaMagPre { get; }

		/// <summary>
		/// Value of variable $TBA_MAG_MAX
		/// </summary>
		public double TbaMagMax { get; }

		/// <summary>
		/// Value of variable $TBA_MAGAXS
		/// </summary>
		public double[] TbaMagaxs { get; }

		/// <summary>
		/// Value of variable $TBA_CURAXS
		/// </summary>
		public double[] TbaCuraxs { get; }

		/// <summary>
		/// Value of variable $TBA_PRVAXS
		/// </summary>
		public double[] TbaPrvaxs { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
