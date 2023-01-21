#include <stdio.h>
//No user header files specified to include.
#include "sample_function_003_002_stub.h"

/*
 *	Buffers for the fclose stub method.
 */
long			fclose_called_count;
int				fclose_return_value[STUB_BUFFER_SIZE_1];
char*			fclose__FileName[STUB_BUFFER_SIZE_1];
char			fclose__FileName_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			fclose__FileName_value_size[STUB_BUFFER_SIZE_1];
char*			fclose__Mode[STUB_BUFFER_SIZE_1];
char			fclose__Mode_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			fclose__Mode_value_size[STUB_BUFFER_SIZE_1];
FILE*			fclose__Stream[STUB_BUFFER_SIZE_1];
FILE			fclose__Stream_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			fclose__Stream_value_size[STUB_BUFFER_SIZE_1];
FILE			fclose__Stream_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];
long			fclose__Stream_return_value_size[STUB_BUFFER_SIZE_1];

/*
 *	A function to initialize the buffers for the fclose stub method.
 */
void fclose_init()
{
	//Initialize the number of function calls.
	fclose_called_count = 0;

	//Initialize the buffer to hold the values the fclose stub method will return.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		fclose_return_value[index] = 0;
	}

	//Initialize the buffers for argument _FileName.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		fclose__FileName[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			fclose__FileName_value[index][index2] = 0;
		}
		fclose__FileName_value_size[index] = 0;
	}

	//Initialize the buffers for argument _Mode.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		fclose__Mode[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			fclose__Mode_value[index][index2] = 0;
		}
		fclose__Mode_value_size[index] = 0;
	}

	//Initialize the buffers for argument _Stream.
	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {
		fclose__Stream[index] = 0;
		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {
			fclose__Stream_value[index][index2] = 0;
			fclose__Stream_return_value[index][index2] = 0;
		}
		fclose__Stream_value_size[index] = 0;
		fclose__Stream_return_value_size[index] = 0;
	}

}

/*
 *	Stub method of fclose
 */
_Success_(return != -1) _Check_return_opt_ _ACRTIMP int __cdecl fclose(_In_z_ char const * _FileName, _In_z_ char const * _Mode, _Inout_ FILE * _Stream)
{
	//Get and latch the value from buffer.
	int latchReturn = fclose_return_value[fclose_called_count];

	//Set argument value to buffer.
	fclose__FileName[fclose_called_count] = _FileName;

	//Set values in an area specified by pointer argument to buffer.
	for (int index = 0;
		index < fclose__FileName_value_size[fclose_called_count];
		index++)
	{
		fclose__FileName_value[fclose_called_count][index] = *(_FileName + index);
	}

	//Set argument value to buffer.
	fclose__Mode[fclose_called_count] = _Mode;

	//Set values in an area specified by pointer argument to buffer.
	for (int index = 0;
		index < fclose__Mode_value_size[fclose_called_count];
		index++)
	{
		fclose__Mode_value[fclose_called_count][index] = *(_Mode + index);
	}

	//Set argument value to buffer.
	fclose__Stream[fclose_called_count] = _Stream;

	//Set values in an area specified by pointer argument to buffer.
	for (int index = 0;
		index < fclose__Stream_value_size[fclose_called_count];
		index++)
	{
		fclose__Stream_value[fclose_called_count][index] = *(_Stream + index);
	}

	//Set values in buffer to area specified by pointer argument.
	for (int index = 0;
		index < fclose__Stream_return_value_size[fclose_called_count];
		index++)
	{
		*(_Stream + index) = fclose__Stream_return_value[fclose_called_count][index];
	}

	//Update function call count variable.
	fclose_called_count++;

	//Return latched value.
	return latchReturn;
}

