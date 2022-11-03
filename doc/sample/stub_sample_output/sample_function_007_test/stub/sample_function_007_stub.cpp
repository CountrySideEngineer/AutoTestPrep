#include <stdio.h>
#include <string.h>
//No user header files specified to include.
#include "sample_function_007_stub.h"

long subFunction_called_count;
int subFunction_return_value[STUB_BUFFER_SIZE_1];
int** subFunction_subInput1[STUB_BUFFER_SIZE_1];

void subFunction_init()
{
	subFunction_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFunction_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFunction_subInput1[index] = 0;
	}
}

int subFunction(int** subInput1)
{
	int latchReturn = subFunction_return_value[subFunction_called_count];
	subFunction_subInput1[subFunction_called_count] = subInput1;
	subFunction_called_count++;
	return latchReturn;
}

