#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_003_stub.h"

long subfunction_003_called_count;
int subfunction_003_return_value[STUB_BUFFER_SIZE_1];
int* subfunction_003_input1[STUB_BUFFER_SIZE_1];
int subfunction_003_input1_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long subfunction_003_input1_value_size[STUB_BUFFER_SIZE_1];
int subfunction_003_input1_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long subfunction_003_input1_return_value_size[STUB_BUFFER_SIZE_1];

void subfunction_003_init()
{
	subfunction_003_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_003_return_value[index] = 0;
	}
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

int subfunction_003(int* input1)
{
	int latchReturn = subfunction_003_return_value[subfunction_003_called_count];
	subfunction_003_input1[subfunction_003_called_count] = input1;

	for (int index = 0;
		index < subfunction_003_input1_value_size[subfunction_003_called_count];
		index++)
	{
		subfunction_003_input1_value[subfunction_003_called_count][index] = *(input1 + index);
	}
	for (int index = 0;
		index < subfunction_003_input1_return_value_size[subfunction_003_called_count];
		index++)
	{
		*(input1 + index) = subfunction_003_input1_return_value[subfunction_003_called_count][index];
	}
	subfunction_003_called_count++;
	return latchReturn;
}

