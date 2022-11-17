#include <stdio.h>
#include <Windows.h>

/*
 *	Sample function 1 : Return value - YES / Argument - Not pointer / Subfunction - NO
 *	@param	input1	None poitner input 1.
 *	@param	input2	None pointer input 2.
 *
 *	@return	Difference between input1 and input2.
 */
int sample_function_001(int input1, int input2)
{
	int result_data = 0;
	
	if (input1 < input2) {
		result_data = input2 - input1;
	} else {
		result_data = input1 - input2;
	}
	
	return result_data;
}

/*
 *	Sample function 2 : Reutrn Value - YES / Argument - Pointer / Subfunctoin - NO
 *	The argument pointer is not array.
 *	@param	*input1	Poitner input 1.
 *	@param	*input2	Pointer input 2.
 *
 *	@return	Difference between input1 and input2.
 */
int sample_function_002(int* input1, int* input2)
{
	int result_data = 0;
	
	if (*input1 < *input2) {
		result_data = *input2 - *input1;
	} else {
		result_data = *input1 - *input2;
	}
	
	return result_data;
}

/*
 *	Sample function 3 : Reutrn Value - YES / Argument - Pointer / Subfunctoin - NO
 *	The argument pointer is array.
 *	@param	*input1	Poitner input 1.
 *	@param	*input2	Pointer input 2.
 *
 *	@return	Pow of input1 or input2.
 */
int sample_function_003(int* input1, int* input2)
{
	int result_data = 0;
	int input = 0;
	
	if (*input1 < *input2) {
		input = *(input2 + 1);
	} else {
		input = *(input1 + 1);
	}
	result_data = input * input;
	
	return result_data;
}

/*
 *	Sample function 3 : Return Value - YES / Argument - Pointer, input and output / Subfunction - NO
 *	The argument pointer is array/
 *	@param[in] *input1 Pointer input 1.
 *	@param[out] *input2 Pointer input 2, for output.
 * 
 *	@return *input1 * *(input1 + 1);
 *  
 */
int sample_function_004(int* input1, int* input2)
{
	int result = *input1;

	*input2 = *input1;
	*(input2 + 1) = *(input1 + 1);

	result = (*input1) + *(input1 + 1);

	return result;
}
