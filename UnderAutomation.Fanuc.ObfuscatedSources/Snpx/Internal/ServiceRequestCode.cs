//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public enum ServiceRequestCode : byte {


		PLC_SHORT_STATUS = 0,


		GET_PROGNAME = 3,


		READ_SYS_MEM = 4,


		READ_TASK_MEM = 5,


		READ_PROG_MEM = 6,


		WRITE_SYS_MEM = 7,


		WRITE_TASK_MEM = 8,


		WRITE_PROG_MEM = 9,


		PROG_LOGON = 32,


		CHANGE_PRIV = 33,


		SET_CPU_ID = 34,


		SET_PLC_RUN = 35,


		SET_PLC_TIME = 36,


		GET_PKC_TIME = 37,


		GET_FAULT = 56,


		CLR_FAULT = 57,


		PROG_STORE = 63,


		PROG_LOAD = 64,


		GET_INFO = 67,


		TOGGLE_FORCE_SYS_MEM = 68,


		INIT = 79,
	}
}
