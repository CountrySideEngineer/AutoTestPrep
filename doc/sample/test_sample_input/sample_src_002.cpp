#include <stdio.h>
#include <Windows.h>

//Sample function which has an argument and returns a value.
int subfunction_001(int input1);

//Sample function which has pointer argument as input and returns a value.
int subfunction_002(int* input1);

//Sample function which has pointer argument as output and returns a value.
int subfunction_003(int* input1);

/*
 *	sample function which calls subfunction and returns a value the function returned.
 *	@param	input1	Value to pass to subfunction.
 *
 *	@returns	Returns the value the subfunction returned.
 */
int sample_function_002_001(int input1)
{
	int result = subfunction_001(input1);
	
	return result;
}

/*
 *	Sample function which calls subfunction and returns a value the subfunction has returned.
 *	@param	input1	Value to pass to subfunction.
 *
 *	@returns	Returns the value the subfunction returned.
 */
int sample_function_002_002(int input1)
{
	int buf[200] = { 0 };
	
	for (int index = 0; index < input1; index++) {
		buf[index] = index;
	}
	int result = subfunction_002(buf);
	
	return result;
}

/*
 *	Sample function which calls subfunction and returns values via pointer argument.
 *	@param	input1	Value to pass to subfunction.
 *
 *	@returns	Returns the value the subfunction returned.
 */
int sample_function_002_003(int input1)
{
	int buf[200] = { 0 };
	
	subfunction_003(buf);
	
	int result = buf[input1];
	
	return result;
}

/*
 *	Sample function which calls a sub function multiple times.
 *
 *	@param	input1	Number of subfunction calls.
 *
 *	@returns	Returns the value the sub function returned last time.
 */
int sample_function_002_004(int input1)
{
	int result = 0;
	for (int index = 0; index < input1; index++) {
		result = subfunction_001(index + 1);
	}
	
	return result;
}

/**
 *	Sample function which calls a sub functions multiple times.
 *
 *	@param	input1	The number of sub function calls.
 *
 *	return The number of sub function called.
 */
int sample_function_002_005(int input1)
{
	int buf[100] = { 0 };
	
	for (int index = 0; index < input1; index++) {
		buf[index] = index;
		subfunction_002(buf);
	}
	
	return input1;
}

int sample_function_002_006(int input1)
{
	int buf[100] = { 0 };
	int result = 0;
	
	for (int index = 0; index < input1; index++) {
		subfunction_003(&buf[index]);
		result += buf[index];
	}
	
	return result;
}
