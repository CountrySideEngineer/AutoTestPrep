#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_004_stub.h"

/*
 *	Buffers for the subfunction_001 stub method.
 */
long			subfunction_001_called_count;
int				subfunction_001_return_value[STUB_BUFFER_SIZE_1];
int				subfunction_001_input1[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the subfunction_001 stub method.
 */
void subfunction_001_init()
{
	//Initialize the number of function calls.
	subfunction_001_called_count = 0;

	//Initialize the buffer to hold the values the subfunction_001 stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_return_value[index] = 0;
	}

	//Initialize the buffer for argument input1.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_input1[index] = 0;
	}

}

/*
 *	Stub method of subfunction_001
 */
int subfunction_001(int input1)
{
	//Get and latch the value from buffer.
	int latchReturn = subfunction_001_return_value[subfunction_001_called_count];

	//Set argument value to buffer.
	subfunction_001_input1[subfunction_001_called_count] = input1;

	//Update function call count variable.
	subfunction_001_called_count++;

	//Return latched value.
	return latchReturn;
}

