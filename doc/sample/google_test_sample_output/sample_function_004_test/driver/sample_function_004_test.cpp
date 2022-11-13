#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_004_test.h"
#include "sample_function_004_stub.h"
long outsideVariable;
extern short insideVariable;


//Test target function declare
int sample_function_004(int input1, int* input2);

void sample_function_004_utest::SetUp()
{
	subFuncA_init();
}


TEST_F(sample_function_004_utest, sample_function_004_utest_1)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 0;
	_input2[0] = 0;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_2)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 0;
	_input2[0] = 1;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(0, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_3)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 1;
	_input2[0] = 0;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_4)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 1;
	_input2[0] = 1;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(1, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_5)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 2;
	_input2[0] = 2;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_6)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 2;
	_input2[0] = 2;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_7)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 3;
	_input2[0] = 3;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(3, _ret_val);
}

TEST_F(sample_function_004_utest, sample_function_004_utest_8)
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;

	//Setup test parameters.
	input1 = 3;
	_input2[0] = 3;
	input2 = &input2[0];

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(3, _ret_val);
}

