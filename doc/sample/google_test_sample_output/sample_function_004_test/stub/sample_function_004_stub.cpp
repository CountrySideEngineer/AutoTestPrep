#include <stdio.h>
#include <string.h>
//No user header files specified to include.
#include "sample_function_004_stub.h"

long subFunc_001_called_count;
int subFunc_001_return_value[STUB_BUFFER_SIZE_1];
int subFunc_001_input[STUB_BUFFER_SIZE_1];

void subFunc_001_init()
{
	subFunc_001_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFunc_001_return_value[index] = 0;
	}
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFunc_001_input[index] = 0;
	}
}

int subFunc_001(int input)
{
	int latchReturn = subFunc_001_return_value[subFunc_001_called_count];
	subFunc_001_input[subFunc_001_called_count] = input;
	subFunc_001_called_count++;
	return latchReturn;
}

