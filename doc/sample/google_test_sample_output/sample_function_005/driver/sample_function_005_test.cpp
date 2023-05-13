/*
 *	sample_function_005 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_005_test.h"
//No global variables are refered by function sample_function_005.

//Test target function declare
int sample_function_005(VOID * input1, int * input2);

//Initialize test stub by calling methods to initialize them.
void sample_function_005_utest::SetUp()
{
}


TEST_F(sample_function_005_utest, sample_function_005_utest_001)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_002)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_003)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_004)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_005)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_006)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_007)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_008)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_009)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_010)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_011)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_012)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_013)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_014)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_015)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_005_utest, sample_function_005_utest_016)
{
	//Declare argument for target
	int _input1[100];
	VOID* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = (VOID*)&_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_005(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
}

