#include <stdio.h>
#include "UserStubHeader.h"
#include "sample_function_002_stub.h"

/*
 *	Buffers for the subFuncA_002 stub method.
 */
long			subFuncA_002_called_count;
int				subFuncA_002_return_value[STUB_BUFFER_SIZE_1];
int				subFuncA_002_subInput1[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the subFuncA_002 stub method.
 */
void subFuncA_002_init()
{
	//Initialize the number of function calls.
	subFuncA_002_called_count = 0;

	//Initialize the buffer to hold the values the subFuncA_002 stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFuncA_002_return_value[index] = 0;
	}

	//Initialize the buffer for argument subInput1.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFuncA_002_subInput1[index] = 0;
	}

}

/*
 *	Stub method of subFuncA_002
 */
int subFuncA_002(int subInput1)
{
	//Get and latch the value from buffer.
	int latchReturn = subFuncA_002_return_value[subFuncA_002_called_count];

	//Set argument value to buffer.
	subFuncA_002_subInput1[subFuncA_002_called_count] = subInput1;

	//Update function call count variable.
	subFuncA_002_called_count++;

	//Return latched value.
	return latchReturn;
}

