#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

/*
 *	Buffers for the GetLastError stub method.
 */
extern long GetLastError_called_count;
extern DWORD GetLastError_return_value[];
extern DWORD GetLastError_dwErrCode[];

/*
 *	A function to initialize the buffers for the GetLastError stub method.
 */
void GetLastError_init();

