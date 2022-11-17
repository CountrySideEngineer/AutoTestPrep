#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_004_test.h"
//No global variables are refered by function sample_function_004.

//Test target function declare
int sample_function_004(int* input1, int* input2);

void sample_function_004_utest::SetUp()
{
}


TEST_F(sample_function_004_utest, sample_function_004_utest_1)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_2)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_3)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-1, _ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_4)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_5)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 0;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-2, _ret_val);
	ASSERT_EQ(0, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_6)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_7)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_8)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_9)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(3, _ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_10)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 1;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-1, _ret_val);
	ASSERT_EQ(1, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_11)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-1, _ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_12)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_13)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-2, _ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_14)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_15)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -1;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-3, _ret_val);
	ASSERT_EQ(-1, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_16)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_17)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(3, _ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_18)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_19)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(4, _ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_20)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = 2;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(2, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_21)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 0;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-2, _ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(0, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_22)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-1, _ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_23)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = -1;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-3, _ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(-1, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_24)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = 2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(2, _input2[1]);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_25)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	_input1[0] = -2;
	_input1[1] = -2;
	input1 = &_input1[0];
	input2 = &_input2[0];

	int _ret_val = sample_function_004(&input1, &input2);

	ASSERT_EQ(-4, _ret_val);
	ASSERT_EQ(-2, _input2[0]);
	ASSERT_EQ(-2, _input2[1]);
}

