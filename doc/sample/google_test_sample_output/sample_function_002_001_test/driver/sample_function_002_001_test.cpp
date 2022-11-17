#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_001_test.h"
#include "sample_function_002_001_stub.h"
//No global variables are refered by function sample_function_002_001.

//Test target function declare
int sample_function_002_001(int input1);

void sample_function_002_001_utest::SetUp()
{
	subfunction_001_init();
}


TEST_F(sample_function_002_001_utest, sample_function_002_001_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;
	subfunction_001_return_value[0] = 0;

	int _ret_val = sample_function_002_001(input1);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, subfunction_001_called_count);
	ASSERT_EQ(0, subfunction_001_input1[0]);
}

TEST_F(sample_function_002_001_utest, sample_function_002_001_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_001_return_value[0] = 1;

	int _ret_val = sample_function_002_001(input1);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_001_called_count);
	ASSERT_EQ(1, subfunction_001_input1[0]);
}

TEST_F(sample_function_002_001_utest, sample_function_002_001_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 9;
	subfunction_001_return_value[0] = 99;

	int _ret_val = sample_function_002_001(input1);

	ASSERT_EQ(99, _ret_val);
	ASSERT_EQ(1, subfunction_001_called_count);
	ASSERT_EQ(9, subfunction_001_input1[0]);
}

TEST_F(sample_function_002_001_utest, sample_function_002_001_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 10;
	subfunction_001_return_value[0] = 100;

	int _ret_val = sample_function_002_001(input1);

	ASSERT_EQ(100, _ret_val);
	ASSERT_EQ(1, subfunction_001_called_count);
	ASSERT_EQ(10, subfunction_001_input1[0]);
}

