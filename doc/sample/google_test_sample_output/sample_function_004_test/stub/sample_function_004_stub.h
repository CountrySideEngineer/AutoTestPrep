#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

extern long subFuncA_called_count;
extern int subFuncA_return_value[];
extern int** subFuncA_subInput1[];

void subFuncA_init();

