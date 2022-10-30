#include <stdio.h>
#include <string.h>
//No user header files specified to include.

long subFunction_called_count;

void subFunction_init()
{
	subFunction_called_count = 0;
}

void subFunction()
{
	subFunction_called_count++;
}

