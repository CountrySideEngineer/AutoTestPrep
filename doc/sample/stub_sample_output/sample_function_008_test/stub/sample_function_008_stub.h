#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

extern long subFunction_called_count;
extern int subFunction_return_value[];
extern int** subFunction_subInput1[];
extern int subFunction_subInput1_return_value[][STUB_BUFFER_SIZE_2];
extern long subFunction_subInput1_return_value_size[];

void subFunction_init();

