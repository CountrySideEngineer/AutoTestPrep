/*
 *	sample_function_003_001 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_003_001_test.h"
#include "sample_function_003_001_stub.h"
//No global variables are refered by function sample_function_003_001.

//Test target function declare
int sample_function_003_001(DWORD input1);

//Initialize test stub by calling methods to initialize them.
void sample_function_003_001_utest::SetUp()
{
	GetLastError_init();
}


TEST_F(sample_function_003_001_utest, sample_function_003_001_utest_001)
{
	//Declare argument for target
	DWORD input1;

	//Setup test parameters.
	input1 = 0;
	GetLastError_return_value[0] = 0;

	int _ret_val = sample_function_003_001(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, GetLastError_called_count);
	ASSERT_EQ(0, SetLastError_called_count);
}

TEST_F(sample_function_003_001_utest, sample_function_003_001_utest_002)
{
	//Declare argument for target
	DWORD input1;

	//Setup test parameters.
	input1 = 1;
	GetLastError_return_value[0] = 1;

	int _ret_val = sample_function_003_001(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, GetLastError_called_count);
	ASSERT_EQ(0, SetLastError_dwErrCode[0]);
}

TEST_F(sample_function_003_001_utest, sample_function_003_001_utest_003)
{
	//Declare argument for target
	DWORD input1;

	//Setup test parameters.
	input1 = 0xFFFFFFFF;
	GetLastError_return_value[0] = 0xFFFFFFFF;

	int _ret_val = sample_function_003_001(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0xFFFFFFFF, _ret_val);
	ASSERT_EQ(1, GetLastError_called_count);
	ASSERT_EQ(1, SetLastError_dwErrCode[0]);
}

TEST_F(sample_function_003_001_utest, sample_function_003_001_utest_004)
{
	//Declare argument for target
	DWORD input1;

	//Setup test parameters.

	int _ret_val = sample_function_003_001(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, GetLastError_called_count);
	ASSERT_EQ(0xFFFFFFFF, SetLastError_dwErrCode[0]);
}

