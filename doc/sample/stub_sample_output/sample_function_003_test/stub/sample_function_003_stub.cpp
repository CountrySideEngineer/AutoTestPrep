#include <stdio.h>
#include <string.h>
//No user header files specified to include.
#include "sample_function_003_stub.h"

long subFunction_called_count;
int* subFunction_return_value[STUB_BUFFER_SIZE_1];

void subFunction_init()
{
	subFunction_called_count = 0;
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		subFunction_return_value[index] = NULL;
	}
}

int* subFunction()
{
	int* latchReturn = subFunction_return_value[subFunction_called_count];
	subFunction_called_count++;
	return latchReturn;
}

