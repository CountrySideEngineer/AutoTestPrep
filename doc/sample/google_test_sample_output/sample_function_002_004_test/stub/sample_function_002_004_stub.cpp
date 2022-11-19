#include <stdio.h>
//No user header files specified to include.
#include "sample_function_002_004_stub.h"

long subfunction_001_called_count;
int subfunction_001_return_value[STUB_BUFFER_SIZE_1];
int subfunction_001_input1[STUB_BUFFER_SIZE_1];

void subfunction_001_init()
{
	subfunction_001_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subfunction_001_input1[index] = 0;
	}
}

int subfunction_001(int input1)
{
	int latchReturn = subfunction_001_return_value[subfunction_001_called_count];
	subfunction_001_input1[subfunction_001_called_count] = input1;
	subfunction_001_called_count++;
	return latchReturn;
}

