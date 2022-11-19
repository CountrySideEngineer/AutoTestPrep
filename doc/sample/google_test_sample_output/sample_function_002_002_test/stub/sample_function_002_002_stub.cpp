#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_002_stub.h"

long subfunction_002_called_count;
int subfunction_002_return_value[STUB_BUFFER_SIZE_1];
int* subfunction_002_input1[STUB_BUFFER_SIZE_1];
int subfunction_002_input1_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long subfunction_002_input1_value_size[STUB_BUFFER_SIZE_1];

void subfunction_002_init()
{
	subfunction_002_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_002_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_002_input1[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			subfunction_002_input1_value[index][index2] = 0;
		}
		subfunction_002_input1_value_size[index] = 0;
	}
}

int subfunction_002(int* input1)
{
	int latchReturn = subfunction_002_return_value[subfunction_002_called_count];
	subfunction_002_input1[subfunction_002_called_count] = input1;

	for (int index = 0;
		index < subfunction_002_input1_value_size[subfunction_002_called_count];
		index++)
	{
		subfunction_002_input1_value[subfunction_002_called_count][index] = *(input1 + index);
	}
	subfunction_002_called_count++;
	return latchReturn;
}

