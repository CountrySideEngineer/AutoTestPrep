#include <stdio.h>
#include <string.h>
//No user header files specified to include.
#include "sample_function_004_stub.h"

long subFuncA_called_count;
int subFuncA_return_value[STUB_BUFFER_SIZE_1];
int** subFuncA_subInput1[STUB_BUFFER_SIZE_1];

void subFuncA_init()
{
	subFuncA_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFuncA_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFuncA_subInput1[index] = 0;
	}
}

int subFuncA(int** subInput1)
{
	int latchReturn = subFuncA_return_value[subFuncA_called_count];
	subFuncA_subInput1[subFuncA_called_count] = subInput1;
	subFuncA_called_count++;
	return latchReturn;
}

