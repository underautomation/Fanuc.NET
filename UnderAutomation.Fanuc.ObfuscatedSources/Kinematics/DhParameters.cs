//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using Ftp.Variables;

namespace Kinematics {
	/// <summary>
	/// Denavit-Hartenberg parameters for a 6-axis robot arm.
	/// </summary>
	public class DhParameters : IDhParameters {

		/// <summary>
		/// User-defined tag for associating additional data with this instance.
		/// </summary>
		public object Tag;

		/// <summary>
		/// Initializes a new empty instance of <xref href="UnderAutomation.Fanuc.Kinematics.DhParameters" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public DhParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.Fanuc.Kinematics.DhParameters" data-throw-if-not-resolved="false"></xref> with the specified values.
		/// </summary>
		/// <param name="d4">DH parameter D4 (mm).</param>
		/// <param name="d5">DH parameter D5 (mm).</param>
		/// <param name="d6">DH parameter D6 (mm).</param>
		/// <param name="a1">DH parameter A1 (mm).</param>
		/// <param name="a2">DH parameter A2 (mm).</param>
		/// <param name="a3">DH parameter A3 (mm).</param>
		public DhParameters(double d4, double d5, double d6, double a1, double a2, double a3)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.Fanuc.Kinematics.DhParameters" data-throw-if-not-resolved="false"></xref> by copying from an existing <xref href="UnderAutomation.Fanuc.Kinematics.IDhParameters" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		/// <param name="parameters">The source parameters to copy.</param>
		public DhParameters(IDhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


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

		/// <summary>
		/// DH parameter D4 (mm).
		/// </summary>
		public double D4 { get; set; }

		/// <summary>
		/// DH parameter D5 (mm).
		/// </summary>
		public double D5 { get; set; }

		/// <summary>
		/// DH parameter D6 (mm).
		/// </summary>
		public double D6 { get; set; }

		/// <summary>
		/// DH parameter A1 (mm).
		/// </summary>
		public double A1 { get; set; }

		/// <summary>
		/// DH parameter A2 (mm).
		/// </summary>
		public double A2 { get; set; }

		/// <summary>
		/// DH parameter A3 (mm).
		/// </summary>
		public double A3 { get; set; }

		/// <summary>
		/// Gets the kinematics category determined from the DH parameter values.
		/// </summary>
		public KinematicsCategory KinematicsCategory { get; }
	}
}
