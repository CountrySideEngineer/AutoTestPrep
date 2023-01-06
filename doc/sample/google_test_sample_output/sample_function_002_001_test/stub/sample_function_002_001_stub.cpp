#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_001_stub.h"

/*
 *	Buffers for the subfunction_001 stub method.
 */
long                 subfunction_001_called_count;
int                  subfunction_001_return_value[STUB_BUFFER_SIZE_1];
int                  subfunction_001_input1[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the subfunction_001 stub method.
 */
void subfunction_001_init()
{
	subfunction_001_called_count = 0;

	//Initialize the buffer to hold the value the subfunction_001 stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_input1[index] = 0;
	}
}

/*
 *	Stub method of subfunction_001
 */
int subfunction_001(int input1)
{
	int latchReturn = subfunction_001_return_value[subfunction_001_called_count];
	subfunction_001_input1[subfunction_001_called_count] = input1;
	subfunction_001_called_count++;
	return latchReturn;
}

