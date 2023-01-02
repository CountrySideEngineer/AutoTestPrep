#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

/*
 *	Buffers for the subfunction_001 stub method.
 */
extern long subfunction_001_called_count;
extern int subfunction_001_return_value[];
extern int subfunction_001_input1[];

/*
 *	A function to initialize the buffers for the subfunction_001 stub method.
 */
void subfunction_001_init();

