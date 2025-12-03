//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Kinematics.Internal;

namespace Kinematics {
	/// <summary>
	/// Fanuc Robot Known Arm Models
	/// </summary>
	public enum ArmKinematicModels {

		/// <summary>
		/// ARC Mate 0iA
		/// </summary>
		[ArmModel("ARC Mate 0iA", -660, 0, -100, 150, 620, 100)]
ARCMate0iA = 0,

		/// <summary>
		/// ARC Mate 0iB
		/// </summary>
		[ArmModel("ARC Mate 0iB", -660, 0, -100, 150, 620, 100)]
ARCMate0iB = 1,

		/// <summary>
		/// ARC Mate 0iB
		/// </summary>
		[ArmModel("ARC Mate 0iB", -660, 0, -100, 150, 620, 100)]
ARCMate0iB_2 = 2,

		/// <summary>
		/// ARCMate100iD
		/// </summary>
		[ArmModel("ARCMate100iD", -700, 0, -75, 75, 640, 195)]
ARCMate100iD = 3,

		/// <summary>
		/// ARCMate100iD/10L
		/// </summary>
		[ArmModel("ARCMate100iD/10L", -900, 0, -75, 75, 640, 195)]
ARCMate100iD10L = 4,

		/// <summary>
		/// ARCMate100iD/16S
		/// </summary>
		[ArmModel("ARCMate100iD/16S", -555, 0, -90, 75, 440, 195)]
ARCMate100iD16S = 5,

		/// <summary>
		/// ARCMate100iD/8L
		/// </summary>
		[ArmModel("ARCMate100iD/8L", -1100, 0, -75, 75, 840, 195)]
ARCMate100iD8L = 6,

		/// <summary>
		/// ARCMate120iD
		/// </summary>
		[ArmModel("ARCMate120iD", -890, 0, -90, 75, 840, 215)]
ARCMate120iD = 7,

		/// <summary>
		/// ARCMate120iD/12L
		/// </summary>
		[ArmModel("ARCMate120iD/12L", -1340, 0, -75, 75, 840, 215)]
ARCMate120iD12L = 8,

		/// <summary>
		/// ARCMate120iD/35
		/// </summary>
		[ArmModel("ARCMate120iD/35", -890, 0, -90, 75, 840, 215)]
ARCMate120iD35 = 9,

		/// <summary>
		/// CR-14iA/L
		/// </summary>
		[ArmModel("CR-14iA/L", -420, 0, -80, 50, 440, 35)]
CR14iAL = 10,

		/// <summary>
		/// CR-15iA
		/// </summary>
		[ArmModel("CR-15iA", -700, 0, -75, 75, 640, 195)]
CR15iA = 11,

		/// <summary>
		/// CR-35iA
		/// </summary>
		[ArmModel("CR-35iA", -860, 0, -100, 150, 790, 150)]
CR35iA = 12,

		/// <summary>
		/// CR-7iA
		/// </summary>
		[ArmModel("CR-7iA", -335, 0, -80, 50, 330, 35)]
CR7iA = 13,

		/// <summary>
		/// CR-7iA/L
		/// </summary>
		[ArmModel("CR-7iA/L", -420, 0, -80, 50, 440, 35)]
CR7iAL = 14,

		/// <summary>
		/// CRX-10iA
		/// </summary>
		[ArmModel("CRX-10iA", -540, 150, -160, 0, 540, 0)]
CRX10iA = 15,

		/// <summary>
		/// CRX-10iA/L
		/// </summary>
		[ArmModel("CRX-10iA/L", -540, 150, -160, 0, 710, 0)]
CRX10iAL = 16,

		/// <summary>
		/// LRMate200iD
		/// </summary>
		[ArmModel("LRMate200iD", -335, 0, -80, 50, 330, 35)]
LRMate200iD = 17,

		/// <summary>
		/// LRMate200iD/7C
		/// </summary>
		[ArmModel("LRMate200iD/7C", -335, 0, -92, 50, 330, 35)]
LRMate200iD7C = 18,

		/// <summary>
		/// LRMate200iD/7L
		/// </summary>
		[ArmModel("LRMate200iD/7L", -420, 0, -80, 50, 440, 35)]
LRMate200iD7L = 19,

		/// <summary>
		/// LRMate200iD/7LC
		/// </summary>
		[ArmModel("LRMate200iD/7LC", -420, 0, -92, 50, 440, 35)]
LRMate200iD7LC = 20,

		/// <summary>
		/// Laser Robot HA
		/// </summary>
		[ArmModel("Laser Robot HA", -900, 0, -190, 312, 800, 225)]
LaserRobotHA = 21,

		/// <summary>
		/// M-10iA 10M
		/// </summary>
		[ArmModel("M-10iA 10M", -655, 0, -100, 150, 600, 150)]
M10iA10M = 22,

		/// <summary>
		/// M-10iA 10MS
		/// </summary>
		[ArmModel("M-10iA 10MS", -530, 0, -100, 150, 400, 150)]
M10iA10MS = 23,

		/// <summary>
		/// M-10iA 12
		/// </summary>
		[ArmModel("M-10iA 12", -640, 0, -100, 150, 600, 200)]
M10iA12 = 24,

		/// <summary>
		/// M-10iA 12S
		/// </summary>
		[ArmModel("M-10iA 12S", -510, 0, -100, 150, 400, 200)]
M10iA12S = 25,

		/// <summary>
		/// M-10iA 7L
		/// </summary>
		[ArmModel("M-10iA 7L", -860, 0, -100, 150, 600, 200)]
M10iA7L = 26,

		/// <summary>
		/// M-10iA 8L
		/// </summary>
		[ArmModel("M-10iA 8L", -1080, 0, -100, 150, 780, 200)]
M10iA8L = 27,

		/// <summary>
		/// M-2000iA 1700L
		/// </summary>
		[ArmModel("M-2000iA 1700L", -2480, 0, -600, 500, 1700, 350)]
M2000iA1700L = 28,

		/// <summary>
		/// M-2000iA 2300
		/// </summary>
		[ArmModel("M-2000iA 2300", -1500, 0, -600, 500, 1700, 350)]
M2000iA2300 = 29,

		/// <summary>
		/// M-2000iA/1200
		/// </summary>
		[ArmModel("M-2000iA/1200", -1500, 0, -445, 500, 1700, 350)]
M2000iA1200 = 30,

		/// <summary>
		/// M-2000iA/900L
		/// </summary>
		[ArmModel("M-2000iA/900L", -2480, 0, -445, 500, 1700, 350)]
M2000iA900L = 31,

		/// <summary>
		/// M-20iA
		/// </summary>
		[ArmModel("M-20iA", -835, 0, -100, 150, 790, 250)]
M20iA = 32,

		/// <summary>
		/// M-20iA 12L
		/// </summary>
		[ArmModel("M-20iA 12L", -1040, 0, -100, 150, 790, 250)]
M20iA12L = 33,

		/// <summary>
		/// M-20iA 20M
		/// </summary>
		[ArmModel("M-20iA 20M", -860, 0, -100, 150, 790, 150)]
M20iA20M = 34,

		/// <summary>
		/// M-20iA 35M
		/// </summary>
		[ArmModel("M-20iA 35M", -860, 0, -100, 150, 790, 150)]
M20iA35M = 35,

		/// <summary>
		/// M-20iB/25C
		/// </summary>
		[ArmModel("M-20iB/25C", -865, 0, -113, 75, 905, 120)]
M20iB25C = 36,

		/// <summary>
		/// M-410iC 110
		/// </summary>
		[ArmModel("M-410iC 110", 1505, 0, -1505, 260, 945, -252)]
M410iC110 = 37,

		/// <summary>
		/// M-410iC 185
		/// </summary>
		[ArmModel("M-410iC 185", 1945, 0, -1945, 390, 1220, -159)]
M410iC185_2 = 38,

		/// <summary>
		/// M-410iC 185
		/// </summary>
		[ArmModel("M-410iC 185", 1945, 0, -1945, 390, 1220, -159)]
M410iC185 = 39,

		/// <summary>
		/// M-410iC 500
		/// </summary>
		[ArmModel("M-410iC 500", 1945, 0, -1945, 390, 1220, -172)]
M410iC500 = 40,

		/// <summary>
		/// M-410iC 500
		/// </summary>
		[ArmModel("M-410iC 500", 1945, 0, -1945, 390, 1220, -172)]
M410iC500_2 = 41,

		/// <summary>
		/// M-800iA/60
		/// </summary>
		[ArmModel("M-800iA/60", -900, 0, -190, 312, 800, 225)]
M800iA60 = 42,

		/// <summary>
		/// M-900iB 280L
		/// </summary>
		[ArmModel("M-900iB 280L", -1705, 0, -260, 370, 1050, 200)]
M900iB280L = 43,

		/// <summary>
		/// M-900iB 330L
		/// </summary>
		[ArmModel("M-900iB 330L", -1705, 0, -260, 470, 1050, 200)]
M900iB330L = 44,

		/// <summary>
		/// M-900iB 360
		/// </summary>
		[ArmModel("M-900iB 360", -1250, 0, -260, 370, 1050, 200)]
M900iB360 = 45,

		/// <summary>
		/// M-900iB 400L
		/// </summary>
		[ArmModel("M-900iB 400L", -2180, 0, -300, 410, 1120, 250)]
M900iB400L = 46,

		/// <summary>
		/// M-900iB 700
		/// </summary>
		[ArmModel("M-900iB 700", -1285, 0, -300, 410, 1120, 250)]
M900iB700 = 47,

		/// <summary>
		/// M-900iB KAI
		/// </summary>
		[ArmModel("M-900iB KAI", -1250, 0, -260, 370, 1050, 200)]
M900iBKAI = 48,

		/// <summary>
		/// M20iB 25
		/// </summary>
		[ArmModel("M20iB 25", -865, 0, -100, 75, 905, 120)]
M20iB25 = 49,

		/// <summary>
		/// M20iB 35S
		/// </summary>
		[ArmModel("M20iB 35S", -723, 0, -100, 75, 637, 120)]
M20iB35S = 50,

		/// <summary>
		/// M710iC 12L
		/// </summary>
		[ArmModel("M710iC 12L", -1805, 0, -100, 150, 1150, 255)]
M710iC12L = 51,

		/// <summary>
		/// M710iC 20M
		/// </summary>
		[ArmModel("M710iC 20M", -1550, 0, -100, 150, 870, 190)]
M710iC20M = 52,

		/// <summary>
		/// M710iC 45M
		/// </summary>
		[ArmModel("M710iC 45M", -1295, 0, -175, 150, 1150, 170)]
M710iC45M = 53,

		/// <summary>
		/// M710iC 50
		/// </summary>
		[ArmModel("M710iC 50", -1016, 0, -175, 150, 870, 170)]
M710iC50 = 54,

		/// <summary>
		/// P-700iA-New Righty Arm Right Offset
		/// </summary>
		[ArmModel("P-700iA-New Righty Arm Right Offset", -1730, 0, -215, 312, 1075, 225)]
P700iANewRightyArmRightOffset = 55,

		/// <summary>
		/// P350iA 45 Left Hand
		/// </summary>
		[ArmModel("P350iA 45 Left Hand", -1295, 0, -175, 150, 1150, 170)]
P350iA45LeftHand = 56,

		/// <summary>
		/// P350iA 45 Right Hand
		/// </summary>
		[ArmModel("P350iA 45 Right Hand", -1295, 0, -175, 150, 1150, 170)]
P350iA45RightHand = 57,

		/// <summary>
		/// R-1000iA/100F
		/// </summary>
		[ArmModel("R-1000iA/100F", -1015, 0, -190, 320, 870, 225)]
R1000iA100F = 58,

		/// <summary>
		/// R-1000iA/130F
		/// </summary>
		[ArmModel("R-1000iA/130F", -1015, 0, -190, 320, 870, 225)]
R1000iA130F = 59,

		/// <summary>
		/// R-1000iA/80F
		/// </summary>
		[ArmModel("R-1000iA/80F", -1015, 0, -175, 320, 870, 225)]
R1000iA80F = 60,

		/// <summary>
		/// R-2000iB/125L
		/// </summary>
		[ArmModel("R-2000iB/125L", -1635, 0, -215, 312, 1075, 225)]
R2000iB125L = 61,

		/// <summary>
		/// R-2000iB/175L
		/// </summary>
		[ArmModel("R-2000iB/175L", -1480, 0, -235, 312, 1075, 225)]
R2000iB175L = 62,

		/// <summary>
		/// R-2000iC 100S
		/// </summary>
		[ArmModel("R-2000iC 100S", -900, 0, -240, 312, 800, 225)]
R2000iC100S = 63,

		/// <summary>
		/// R-2000iC 270F
		/// </summary>
		[ArmModel("R-2000iC 270F", -1280, 0, -240, 312, 1075, 225)]
R2000iC270F = 64,

		/// <summary>
		/// R-2000iD/100FH
		/// </summary>
		[ArmModel("R-2000iD/100FH", -1230, 0, -225, 312, 1075, 225)]
R2000iD100FH = 65,

		/// <summary>
		/// R1000iA 100F 7
		/// </summary>
		[ArmModel("R1000iA 100F 7", -500, 0, -190, 320, 870, 225)]
R1000iA100F7 = 66,

		/// <summary>
		/// R1000iA 120F 7B
		/// </summary>
		[ArmModel("R1000iA 120F 7B", -500, 0, -335, 320, 870, 225)]
R1000iA120F7B_3 = 67,

		/// <summary>
		/// R1000iA 120F 7B
		/// </summary>
		[ArmModel("R1000iA 120F 7B", -500, 0, -213, 320, 870, 225)]
R1000iA120F7B_2 = 68,

		/// <summary>
		/// R1000iA 120F 7B
		/// </summary>
		[ArmModel("R1000iA 120F 7B", -500, 0, -190, 320, 870, 225)]
R1000iA120F7B = 69,

		/// <summary>
		/// R1000iA 120F 7BS
		/// </summary>
		[ArmModel("R1000iA 120F 7BS", -500, 0, -190, 320, 870, 225)]
R1000iA120F7BS = 70,

		/// <summary>
		/// R1000iA 120F 7BS
		/// </summary>
		[ArmModel("R1000iA 120F 7BS", -500, 0, -335, 320, 870, 225)]
R1000iA120F7BS_3 = 71,

		/// <summary>
		/// R1000iA 120F 7BS
		/// </summary>
		[ArmModel("R1000iA 120F 7BS", -500, 0, -213, 320, 870, 225)]
R1000iA120F7BS_2 = 72,

		/// <summary>
		/// R2000iB 210FS
		/// </summary>
		[ArmModel("R2000iB 210FS", -1230, 0, -235, 312, 1075, 225)]
R2000iB210FS = 73,

		/// <summary>
		/// R2000iB 220US
		/// </summary>
		[ArmModel("R2000iB 220US", -1230, 0, -235, 312, 1075, 225)]
R2000iB220US = 74,

		/// <summary>
		/// R2000iC 125L
		/// </summary>
		[ArmModel("R2000iC 125L", -1730, 0, -215, 312, 1075, 225)]
R2000iC125L = 75,

		/// <summary>
		/// R2000iC 190U
		/// </summary>
		[ArmModel("R2000iC 190U", -1730, 0, -240, 312, 1075, 225)]
R2000iC190U = 76,

		/// <summary>
		/// R2000iC 210F
		/// </summary>
		[ArmModel("R2000iC 210F", -1280, 0, -215, 312, 1075, 225)]
R2000iC210F = 77,

		/// <summary>
		/// R2000iC 210L
		/// </summary>
		[ArmModel("R2000iC 210L", -1730, 0, -240, 312, 1075, 225)]
R2000iC210L = 78,

		/// <summary>
		/// R2000iC 210WE
		/// </summary>
		[ArmModel("R2000iC 210WE", -1280, 0, -227, 430, 1075, 225)]
R2000iC210WE = 79,

		/// <summary>
		/// R2000iC 210WE proto
		/// </summary>
		[ArmModel("R2000iC 210WE proto", -1280, 0, -215, 312, 1075, 225)]
R2000iC210WEProto = 80,

		/// <summary>
		/// R2000iC 220U
		/// </summary>
		[ArmModel("R2000iC 220U", -1280, 0, -215, 312, 1075, 225)]
R2000iC220U = 81,
	}
}
