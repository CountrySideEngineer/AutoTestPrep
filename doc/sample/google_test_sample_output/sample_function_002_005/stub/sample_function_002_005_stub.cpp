#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_005_stub.h"

/*
 *	Buffers for the subfunction_002 stub method.
 */
long			subfunction_002_called_count;
int				subfunction_002_return_value[STUB_BUFFER_SIZE_1];
int*			subfunction_002_input1[STUB_BUFFER_SIZE_1];
int				subfunction_002_input1_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			subfunction_002_input1_value_size[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the subfunction_002 stub method.
 */
void subfunction_002_init()
{
	//Initialize the number of function calls.
	subfunction_002_called_count = 0;

	//Initialize the buffer to hold the values the subfunction_002 stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_002_return_value[index] = 0;
	}

	//Initialize the buffers for argument input1.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_002_input1[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			subfunction_002_input1_value[index][index2] = 0;
		}
		subfunction_002_input1_value_size[index] = 0;
	}

}

/*
 *	Stub method of subfunction_002
 */
int subfunction_002(int * input1)
{
	//Get and latch the value from buffer.
	int latchReturn = subfunction_002_return_value[subfunction_002_called_count];

	//Set argument value to buffer.
	subfunction_002_input1[subfunction_002_called_count] = input1;

	//Set values in an area specified by pointer argument to buffer.
	for (int index = 0;
		index < subfunction_002_input1_value_size[subfunction_002_called_count];
		index++)
	{
		subfunction_002_input1_value[subfunction_002_called_count][index] = *(input1 + index);
	}

	//Update function call count variable.
	subfunction_002_called_count++;

	//Return latched value.
	return latchReturn;
}

