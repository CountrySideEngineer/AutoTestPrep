#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_001_test.h"
//No global variables are refered by function sample_function_001.

//Test target function declare
int sample_function_001(int input1, int input2);

void sample_function_001_utest::SetUp()
{
}


TEST_F(sample_function_001_utest, sample_function_001_utest_001)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_002)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 1;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_003)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 2;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_004)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 3;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_005)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_006)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 1;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_007)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 2;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_008)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 3;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_009)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_010)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 1;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_011)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 2;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_012)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 3;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_013)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_014)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 1;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_015)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 2;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_001_utest, sample_function_001_utest_016)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 3;

	int _ret_val = sample_function_001(input1, input2);

	ASSERT_EQ(0, _ret_val);
}

