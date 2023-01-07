#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

/*
 *	Buffers for the subfunction_002 stub method.
 */
extern	long			subfunction_002_called_count;
extern	int				subfunction_002_return_value[];
extern	int*			subfunction_002_input1[];
extern	int				subfunction_002_input1_value[][STUB_BUFFER_SIZE_2];
extern	long			subfunction_002_input1_value_size[];

/*
 *	A function to initialize the buffers for the subfunction_002 stub method.
 */
void subfunction_002_init();

