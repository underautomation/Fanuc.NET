//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using Ftp.Variables;

namespace Kinematics {

	public class DhParameters : IDhParameters {


		public object Tag;


		public DhParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public DhParameters(double d4, double d5, double d6, double a1, double a2, double a3)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public DhParameters(IDhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns DH parameters from a known Arm Kinematic Model name. Returns null if not found in enum ArmKinematicModels.
		/// </summary>
		public static DhParameters FromArmKinematicModel(string modelName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns DH parameters from a known Arm Kinematic Model.
		/// </summary>
		public static DhParameters FromArmKinematicModel(ArmKinematicModels model)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates DH parameters from OPW parameters (in meters)
		/// C1 and B are ignored because B is always 0 and C1 is not used in the DH representation.
		/// </summary>
		/// <param name="a1">OPW A1 parameter in meters</param>
		/// <param name="a2">OPW A2 parameter in meters</param>
		/// <param name="c2">OPW C2 parameter in meters</param>
		/// <param name="c3">OPW C3 parameter in meters</param>
		/// <param name="c4">OPW C4 parameter in meters</param>
		public static DhParameters FromOpwParameters(double a1, double a2, double c2, double c3, double c4)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads DH parameters of each robots described in a ROBOGUIDE definition file (*.def). By default, this file is located in "C:\ProgramData\FANUC\ROBOGUIDE\Robot Library".
		/// </summary>
		public static DhParameters[] FromDefFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads DH parameters of each robots described in a ROBOGUIDE definition file (*.def). By default, this file is located in "C:\ProgramData\FANUC\ROBOGUIDE\Robot Library".
		/// </summary>
		public static DhParameters[] FromDefFile(XDocument doc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads DH parameters of each group from a parsed symotn.va file.
		/// </summary>
		public static DhParameters[] FromSymotnFile(SymotnFile file)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads DH parameters from parsed variable $MRR_GRP located in symotn.va.
		/// </summary>
		public static DhParameters FromMrrGrp(MrrGrpVariableType mrrGrp)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public double D4 { get; set; }


		public double D5 { get; set; }


		public double D6 { get; set; }


		public double A1 { get; set; }


		public double A2 { get; set; }


		public double A3 { get; set; }


		public KinematicsCategory KinematicsCategory { get; }
	}
}
