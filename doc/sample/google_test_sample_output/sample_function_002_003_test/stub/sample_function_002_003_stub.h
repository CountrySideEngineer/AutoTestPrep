#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

extern long subfunction_003_called_count;
extern int subfunction_003_return_value[];
extern int* subfunction_003_input1[];
extern int subfunction_003_input1_value[][STUB_BUFFER_SIZE_2];
extern long subfunction_003_input1_value_size[];
extern int subfunction_003_input1_return_value[][STUB_BUFFER_SIZE_2];
extern long subfunction_003_input1_return_value_size[];

void subfunction_003_init();

