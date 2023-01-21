#include <stdio.h>
//No user header files specified to include.
#include "sample_function_003_001_stub.h"

/*
 *	Buffers for the GetLastError stub method.
 */
long			GetLastError_called_count;
DWORD			GetLastError_return_value[STUB_BUFFER_SIZE_1];
DWORD			GetLastError_dwErrCode[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the GetLastError stub method.
 */
void GetLastError_init()
{
	//Initialize the number of function calls.
	GetLastError_called_count = 0;

	//Initialize the buffer to hold the values the GetLastError stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		GetLastError_return_value[index] = 0;
	}

	//Initialize the buffer for argument dwErrCode.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		GetLastError_dwErrCode[index] = 0;
	}

}

/*
 *	Stub method of GetLastError
 */
WINBASEAPI _Check_return_ Post_equals_last_error_ DWORD WINAPI GetLastError(_In_ DWORD dwErrCode)
{
	//Get and latch the value from buffer.
	DWORD latchReturn = GetLastError_return_value[GetLastError_called_count];

	//Set argument value to buffer.
	GetLastError_dwErrCode[GetLastError_called_count] = dwErrCode;

	//Update function call count variable.
	GetLastError_called_count++;

	//Return latched value.
	return latchReturn;
}

