#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_002_test.h"
#include "sample_function_002_002_stub.h"
//No global variables are refered by function sample_function_002_002.

//Test target function declare
int sample_function_002_002(int input1);

void sample_function_002_002_utest::SetUp()
{
	subfunction_002_init();
}


TEST_F(sample_function_002_002_utest, sample_function_002_002_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;
	subfunction_002_return_value[0] = 0;
	subfunction_002_input1_value_size[0] = 0;

	int _ret_val = sample_function_002_002(input1);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1[0][0]);
}

TEST_F(sample_function_002_002_utest, sample_function_002_002_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_002_return_value[0] = 1;
	subfunction_002_input1_value_size[0] = 1;

	int _ret_val = sample_function_002_002(input1);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1[0][0]);
}

TEST_F(sample_function_002_002_utest, sample_function_002_002_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 2;
	subfunction_002_return_value[0] = 2;
	subfunction_002_input1_value_size[0] = 2;

	int _ret_val = sample_function_002_002(input1);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1[0][0]);
	ASSERT_EQ(1, subfunction_002_input1[0][1]);
}

TEST_F(sample_function_002_002_utest, sample_function_002_002_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 9;
	subfunction_002_return_value[0] = 99;
	subfunction_002_input1_value_size[0] = 9;

	int _ret_val = sample_function_002_002(input1);

	ASSERT_EQ(99, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1[0][0]);
	ASSERT_EQ(1, subfunction_002_input1[0][1]);
	ASSERT_EQ(2, subfunction_002_input1[0][2]);
	ASSERT_EQ(3, subfunction_002_input1[0][3]);
	ASSERT_EQ(4, subfunction_002_input1[0][4]);
	ASSERT_EQ(5, subfunction_002_input1[0][5]);
	ASSERT_EQ(6, subfunction_002_input1[0][6]);
	ASSERT_EQ(7, subfunction_002_input1[0][7]);
	ASSERT_EQ(8, subfunction_002_input1[0][8]);
}

TEST_F(sample_function_002_002_utest, sample_function_002_002_utest_005)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 10;
	subfunction_002_return_value[0] = 100;
	subfunction_002_input1_value_size[0] = 10;

	int _ret_val = sample_function_002_002(input1);

	ASSERT_EQ(100, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1[0][0]);
	ASSERT_EQ(1, subfunction_002_input1[0][1]);
	ASSERT_EQ(2, subfunction_002_input1[0][2]);
	ASSERT_EQ(3, subfunction_002_input1[0][3]);
	ASSERT_EQ(4, subfunction_002_input1[0][4]);
	ASSERT_EQ(5, subfunction_002_input1[0][5]);
	ASSERT_EQ(6, subfunction_002_input1[0][6]);
	ASSERT_EQ(7, subfunction_002_input1[0][7]);
	ASSERT_EQ(8, subfunction_002_input1[0][8]);
	ASSERT_EQ(9, subfunction_002_input1[0][9]);
}

