//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public enum AlarmId : short {

		/// <summary>
		/// AccuCal II Error Code
		/// </summary>
		ACAL = 112,

		/// <summary>
		/// Application Shell Error
		/// </summary>
		APPL = 20,

		/// <summary>
		/// Application Shell Error
		/// </summary>
		APSH = 38,

		/// <summary>
		/// Arc Welding Application
		/// </summary>
		ARC = 53,

		/// <summary>
		/// Mnemonic Editor
		/// </summary>
		ASBN = 22,

		/// <summary>
		/// AutoZone Error
		/// </summary>
		ATZN = 138,

		/// <summary>
		/// Position Bumpbox Error
		/// </summary>
		BBOX = 118,

		/// <summary>
		/// Brake Check Error
		/// </summary>
		BRCH = 144,

		/// <summary>
		/// CalMate Error
		/// </summary>
		CALM = 106,

		/// <summary>
		/// Coordinated Motion Softpart
		/// </summary>
		CD = 82,

		/// <summary>
		/// Command Processor Error
		/// </summary>
		CMND = 42,

		/// <summary>
		/// Continuous Turn Softpart
		/// </summary>
		CNTR = 73,

		/// <summary>
		/// Compensator Error
		/// </summary>
		COMP = 59,

		/// <summary>
		/// Condition Handler Error
		/// </summary>
		COND = 4,

		/// <summary>
		/// Common Options Error
		/// </summary>
		COPT = 37,

		/// <summary>
		/// Constant Path Error Code
		/// </summary>
		CPMO = 114,

		/// <summary>
		/// Customer-Specific Errors
		/// </summary>
		CUST = 97,

		/// <summary>
		/// Integrated Vision (Controller Vision)
		/// </summary>
		CVIS = 117,

		/// <summary>
		/// IRDiagnostics
		/// </summary>
		DIAG = 148,

		/// <summary>
		/// Dictionary Processor
		/// </summary>
		DICT = 33,

		/// <summary>
		/// Dual Motion Drive Error
		/// </summary>
		DMDR = 84,

		/// <summary>
		/// Data Monitor Error
		/// </summary>
		DMER = 40,

		/// <summary>
		/// DeviceNet Error
		/// </summary>
		DNET = 76,

		/// <summary>
		/// Data Transfer Between Robots
		/// </summary>
		DTBR = 149,

		/// <summary>
		/// Delta Tool/Frame Softpart
		/// </summary>
		DX = 72,

		/// <summary>
		/// Error Logger
		/// </summary>
		ELOG = 5,

		/// <summary>
		/// File System Error
		/// </summary>
		FILE = 2,

		/// <summary>
		/// Serial Floppy Disk System Error
		/// </summary>
		FLPY = 10,

		/// <summary>
		/// Impedance Control (Force Control)
		/// </summary>
		FORC = 91,

		/// <summary>
		/// Flash File System Error
		/// </summary>
		FRSY = 85,

		/// <summary>
		/// C-Flex Tool Error
		/// </summary>
		FXTL = 136,

		/// <summary>
		/// Host Communications General Error
		/// </summary>
		HOST = 67,

		/// <summary>
		/// Host Communications Runtime Library Error
		/// </summary>
		HRTL = 66,

		/// <summary>
		/// InterBus-S Error
		/// </summary>
		IBS = 88,

		/// <summary>
		/// IC Railzone Error
		/// </summary>
		ICRZ = 124,

		/// <summary>
		/// Interface Panel Error
		/// </summary>
		IFPN = 153,

		/// <summary>
		/// Interpreter Internal Error
		/// </summary>
		INTP = 12,

		/// <summary>
		/// IRPickTool Error
		/// </summary>
		IRPK = 127,

		/// <summary>
		/// Integral Servo Dispenser Error
		/// </summary>
		ISD = 39,

		/// <summary>
		/// Integral Servo Driven Tool Error
		/// </summary>
		ISDT = 95,

		/// <summary>
		/// Manual Jog Task Error
		/// </summary>
		JOG = 19,

		/// <summary>
		/// KAREL Alarm Error
		/// </summary>
		KALM = 122,

		/// <summary>
		/// Language Utility Error
		/// </summary>
		LANG = 21,

		/// <summary>
		/// Arc Errors from Lincoln Electric
		/// </summary>
		LECO = 109,

		/// <summary>
		/// Line Tracking Error
		/// </summary>
		LNTK = 44,

		/// <summary>
		/// Local Stop Error Codes
		/// </summary>
		LSTP = 108,

		/// <summary>
		/// Macro Option Error
		/// </summary>
		MACR = 57,

		/// <summary>
		/// Material Removal Error
		/// </summary>
		MARL = 83,

		/// <summary>
		/// Multi-Arm Sync Instructions Error
		/// </summary>
		MASI = 147,

		/// <summary>
		/// Motion Control Manager Error
		/// </summary>
		MCTL = 6,

		/// <summary>
		/// Memory Manager Error
		/// </summary>
		MEMO = 7,

		/// <summary>
		/// Motion Subsystem Error
		/// </summary>
		MOTN = 15,

		/// <summary>
		/// Multi-Pass Motion Error
		/// </summary>
		MUPS = 48,

		/// <summary>
		/// Option Installation Error
		/// </summary>
		OPTN = 65,

		/// <summary>
		/// Operating System Error
		/// </summary>
		OS = 0,

		/// <summary>
		/// PalletTool Error
		/// </summary>
		PALL = 115,

		/// <summary>
		/// Palletizing Application Error
		/// </summary>
		PALT = 26,

		/// <summary>
		/// PickTool Error
		/// </summary>
		PICK = 132,

		/// <summary>
		/// PC Monitor Error
		/// </summary>
		PMON = 28,

		/// <summary>
		/// Paint Application Errors (Post V6.31)
		/// </summary>
		PNT1 = 86,

		/// <summary>
		/// PaintTool Application Errors #2
		/// </summary>
		PNT2 = 137,

		/// <summary>
		/// Digital I/O Subsystem Error
		/// </summary>
		PRIO = 13,

		/// <summary>
		/// Profibus DP Error
		/// </summary>
		PROF = 92,

		/// <summary>
		/// Program Interpreter Error
		/// </summary>
		PROG = 3,

		/// <summary>
		/// Password Logging Error
		/// </summary>
		PWD = 31,

		/// <summary>
		/// KAREL Queue Manager Error
		/// </summary>
		QMGR = 61,

		/// <summary>
		/// ROS IP Errors
		/// </summary>
		RIPE = 130,

		/// <summary>
		/// SoftPart Built-in Routine for Interpreter Error
		/// </summary>
		ROUT = 17,

		/// <summary>
		/// RPC Error
		/// </summary>
		RPC = 93,

		/// <summary>
		/// Root Pass Memorization Error
		/// </summary>
		RPM = 43,

		/// <summary>
		/// Remote TCP Error
		/// </summary>
		RTCP = 89,

		/// <summary>
		/// Syntax Checking for Teach Pendant Programs Error
		/// </summary>
		SCIO = 25,

		/// <summary>
		/// System Design Tool Error
		/// </summary>
		SDTL = 123,

		/// <summary>
		/// Sealing Application Error
		/// </summary>
		SEAL = 51,

		/// <summary>
		/// Sensor Interface Error
		/// </summary>
		SENS = 58,

		/// <summary>
		/// Shape Generation Error
		/// </summary>
		SHAP = 79,

		/// <summary>
		/// Spot Welding Application Error
		/// </summary>
		SPOT = 23,

		/// <summary>
		/// Ramp Motion SoftPart Error
		/// </summary>
		SPRM = 131,

		/// <summary>
		/// Serial Driver Error
		/// </summary>
		SRIO = 1,

		/// <summary>
		/// Servo in Motion Sub-System Error
		/// </summary>
		SRVO = 11,

		/// <summary>
		/// Special Space Checking Function Error
		/// </summary>
		SSPC = 69,

		/// <summary>
		/// Servo Weld Gun Application Error
		/// </summary>
		SVGN = 30,

		/// <summary>
		/// System Error
		/// </summary>
		SYST = 24,

		/// <summary>
		/// Through-Arc Seam Tracking Error
		/// </summary>
		TAST = 47,

		/// <summary>
		/// TCP Speed Prediction Error
		/// </summary>
		TCPP = 46,

		/// <summary>
		/// Triggering Accuracy Error
		/// </summary>
		TG = 90,

		/// <summary>
		/// Touch Sensing SoftPart Error
		/// </summary>
		THSR = 60,

		/// <summary>
		/// Tracking Jog Error
		/// </summary>
		TJOG = 116,

		/// <summary>
		/// Torch Mate Error
		/// </summary>
		TMAT = 119,

		/// <summary>
		/// Servo Tool Change Error
		/// </summary>
		TOOL = 29,

		/// <summary>
		/// Teach Pendant User Interface Error
		/// </summary>
		TPIF = 9,

		/// <summary>
		/// Tracking SoftPart Error
		/// </summary>
		TRAK = 54,

		/// <summary>
		/// Variable Manager Subsystem Error
		/// </summary>
		VARS = 16,

		/// <summary>
		/// Weaving Error
		/// </summary>
		WEAV = 45,

		/// <summary>
		/// Window I/O Manager Sub-System Error
		/// </summary>
		WNDW = 18,

		/// <summary>
		/// XML Errors
		/// </summary>
		XMLF = 129,
	}
}
