#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_test.h"
//No global variables are refered by function sample_function_002.

//Test target function declare
int sample_function_002(int* input1, int* input2);

void sample_function_002_utest::SetUp()
{
}


TEST_F(sample_function_002_utest, sample_function_002_utest_1)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = &_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_2)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = &_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_3)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = &_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_4)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	input1 = &_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_5)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = &_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_6)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = &_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_7)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = &_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_8)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	input1 = &_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_9)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = &_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_10)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = &_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_11)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = &_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_12)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	input1 = &_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_13)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = &_input1[0];
	_input2[0] = 0;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_14)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = &_input1[0];
	_input2[0] = 1;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_15)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = &_input1[0];
	_input2[0] = 2;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_002_utest, sample_function_002_utest_16)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 3;
	input1 = &_input1[0];
	_input2[0] = 3;
	input2 = &_input2[0];

	int _ret_val = sample_function_002(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

