#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_003_test.h"
#include "sample_function_002_003_stub.h"
//No global variables are refered by function sample_function_002_003.

//Test target function declare
int sample_function_002_003(int input1);

void sample_function_002_003_utest::SetUp()
{
	subfunction_003_init();
}


TEST_F(sample_function_002_003_utest, sample_function_002_003_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;
	subfunction_003_input1_return_value[0][0] = 1;
	subfunction_003_input1_return_value_size[0] = 1;

	int _ret_val = sample_function_002_003(input1);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_003_called_count);
}

TEST_F(sample_function_002_003_utest, sample_function_002_003_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_003_input1_return_value[0][1] = 2;
	subfunction_003_input1_return_value_size[0] = 2;

	int _ret_val = sample_function_002_003(input1);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(1, subfunction_003_called_count);
}

TEST_F(sample_function_002_003_utest, sample_function_002_003_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 9;
	subfunction_003_input1_return_value[0][9] = 99;
	subfunction_003_input1_return_value_size[0] = 10;

	int _ret_val = sample_function_002_003(input1);

	ASSERT_EQ(99, _ret_val);
	ASSERT_EQ(1, subfunction_003_called_count);
}

TEST_F(sample_function_002_003_utest, sample_function_002_003_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 10;
	subfunction_003_input1_return_value[0][10] = 100;
	subfunction_003_input1_return_value_size[0] = 11;

	int _ret_val = sample_function_002_003(input1);

	ASSERT_EQ(100, _ret_val);
	ASSERT_EQ(1, subfunction_003_called_count);
}

