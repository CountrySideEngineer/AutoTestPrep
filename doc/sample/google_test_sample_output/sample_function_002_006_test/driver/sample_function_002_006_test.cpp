#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_006_test.h"
#include "sample_function_002_006_stub.h"
//No global variables are refered by function sample_function_002_006.

//Test target function declare
int sample_function_002_006(int input1);

void sample_function_002_006_utest::SetUp()
{
	subfunction_003_init();
}


TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;
	subfunction_003_input1_return_value[0][0] = 1;
	subfunction_003_input1_return_value_size[0] = 1;

	int _ret_val = sample_function_002_006(input1);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(0, subfunction_003_called_count);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_003_input1_return_value[0][0] = 1;
	subfunction_003_input1_return_value_size[0] = 1;

	int _ret_val = sample_function_002_006(input1);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_003_called_count);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 2;
	subfunction_003_input1_return_value[1][0] = 2;
	subfunction_003_input1_return_value_size[1] = 2;

	int _ret_val = sample_function_002_006(input1);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(2, subfunction_003_called_count);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 3;
	subfunction_003_input1_return_value[2][0] = 3;
	subfunction_003_input1_return_value_size[2] = 3;

	int _ret_val = sample_function_002_006(input1);

	ASSERT_EQ(3, _ret_val);
	ASSERT_EQ(3, subfunction_003_called_count);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_005)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 4;
	subfunction_003_input1_return_value[3][0] = 4;
	subfunction_003_input1_return_value_size[3] = 4;

	int _ret_val = sample_function_002_006(input1);

	ASSERT_EQ(4, _ret_val);
	ASSERT_EQ(4, subfunction_003_called_count);
}

