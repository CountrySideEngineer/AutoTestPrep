/*
 *	sample_function_004 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_004_test.h"

//No global variables are refered by function sample_function_004.

//Test target function declare
int sample_function_004(int * input1, int * input2);

//Initialize test stub by calling methods to initialize them.
void sample_function_004_utest::SetUp()
{
}


TEST_F(sample_function_004_utest, sample_function_004_utest_001)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_002)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_003)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-1, ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_004)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_005)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-2, ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_006)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_007)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_008)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_009)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(3, ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_010)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-1, ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_011)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-1, ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_012)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_013)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-2, ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_014)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_015)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-3, ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_016)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_017)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(3, ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_018)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_019)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(4, ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_020)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_021)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-2, ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_022)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-1, ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_023)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-3, ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_024)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_025)
{
	//Declare argument for target
	int _input1[100];
	int* input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(input1, input2);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(-4, ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

