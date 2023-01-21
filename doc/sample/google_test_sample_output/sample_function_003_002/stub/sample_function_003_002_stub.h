#pragma once
#ifndef	STUB_BUFFER_SIZE_1
#define	STUB_BUFFER_SIZE_1			(200)
#endif
#ifndef	STUB_BUFFER_SIZE_2
#define	STUB_BUFFER_SIZE_2			(300)
#endif

/*
 *	Buffers for the fclose stub method.
 */
extern	long			fclose_called_count;
extern	int				fclose_return_value[];
extern	char*			fclose__FileName[];
extern	char			fclose__FileName_value[][STUB_BUFFER_SIZE_2];
extern	long			fclose__FileName_value_size[];
extern	char*			fclose__Mode[];
extern	char			fclose__Mode_value[][STUB_BUFFER_SIZE_2];
extern	long			fclose__Mode_value_size[];
extern	FILE*			fclose__Stream[];
extern	FILE			fclose__Stream_value[][STUB_BUFFER_SIZE_2];
extern	long			fclose__Stream_value_size[];
extern	FILE			fclose__Stream_return_value[][STUB_BUFFER_SIZE_2];
extern	long			fclose__Stream_return_value_size[];

/*
 *	A function to initialize the buffers for the fclose stub method.
 */
void fclose_init();

