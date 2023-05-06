#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_006_stub.h"

/*
 *	Buffers for the subfunction_003 stub method.
 */
long			subfunction_003_called_count;
int				subfunction_003_return_value[STUB_BUFFER_SIZE_1];
int*			subfunction_003_input1[STUB_BUFFER_SIZE_1];
int				subfunction_003_input1_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			subfunction_003_input1_value_size[STUB_BUFFER_SIZE_1];
int				subfunction_003_input1_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			subfunction_003_input1_return_value_size[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the subfunction_003 stub method.
 */
void subfunction_003_init()
{
	//Initialize the number of function calls.
	subfunction_003_called_count = 0;

	//Initialize the buffer to hold the values the subfunction_003 stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_003_return_value[index] = 0;
	}

	//Initialize the buffers for argument input1.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_003_input1[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			subfunction_003_input1_value[index][index2] = 0;
			subfunction_003_input1_return_value[index][index2] = 0;
		}
		subfunction_003_input1_value_size[index] = 0;
		subfunction_003_input1_return_value_size[index] = 0;
	}

}

/*
 *	Stub method of subfunction_003
 */
int subfunction_003(int * input1)
{
	//Get and latch the value from buffer.
	int latchReturn = subfunction_003_return_value[subfunction_003_called_count];

	//Set argument value to buffer.
	subfunction_003_input1[subfunction_003_called_count] = input1;

	//Set values in an area specified by pointer argument to buffer.
	for (int index = 0;
		index < subfunction_003_input1_value_size[subfunction_003_called_count];
		index++)
	{
		subfunction_003_input1_value[subfunction_003_called_count][index] = *(input1 + index);
	}

	//Set values in buffer to area specified by pointer argument.
	for (int index = 0;
		index < subfunction_003_input1_return_value_size[subfunction_003_called_count];
		index++)
	{
		*(input1 + index) = subfunction_003_input1_return_value[subfunction_003_called_count][index];
	}

	//Update function call count variable.
	subfunction_003_called_count++;

	//Return latched value.
	return latchReturn;
}

