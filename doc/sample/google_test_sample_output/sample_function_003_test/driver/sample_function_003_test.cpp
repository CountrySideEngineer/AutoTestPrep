#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_003_test.h"
//No global variables are refered by function sample_function_003.

//Test target function declare
int sample_function_003(int input1, int* input2, SHORT input3);

void sample_function_003_utest::SetUp()
{
}


TEST_F(sample_function_003_utest, sample_function_003_utest_1)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;
	input3 = 1;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(10, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_2)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;
	input3 = 2;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(20, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_3)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;
	input3 = 3;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(30, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_4)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;
	input3 = 1;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(0, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_5)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;
	input3 = 2;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(10, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_6)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;
	input3 = 3;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(20, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_7)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;
	input3 = 1;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(10, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_8)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;
	input3 = 2;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(0, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_9)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;
	input3 = 3;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(10, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_10)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;
	input3 = 1;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(20, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_11)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;
	input3 = 2;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(10, input2);
}

TEST_F(sample_function_003_utest, sample_function_003_utest_12)
{
	//Declare argument for target
	int input1;
	int input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;
	input3 = 3;

	int _ret_val = sample_function_003(input1, &input2, input3);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(0, input2);
}

