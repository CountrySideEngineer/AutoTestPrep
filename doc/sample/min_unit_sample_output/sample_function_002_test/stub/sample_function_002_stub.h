#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

/*
 *	Buffers for the subFuncA_002 stub method.
 */
extern long subFuncA_002_called_count;
extern int subFuncA_002_return_value[];
extern int subFuncA_002_subInput1[];

/*
 *	A function to initialize the buffers for the subFuncA_002 stub method.
 */
void subFuncA_002_init();

