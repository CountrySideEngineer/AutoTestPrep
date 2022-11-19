#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_004_test.h"
#include "sample_function_002_004_stub.h"
//No global variables are refered by function sample_function_002_004.

//Test target function declare
int sample_function_002_004(int input1);

void sample_function_002_004_utest::SetUp()
{
	subfunction_001_init();
}


TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;
	subfunction_001_return_value[0] = 1;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(0, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_001_return_value[0] = 1;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 2;
	subfunction_001_return_value[1] = 2;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(2, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 3;
	subfunction_001_return_value[2] = 10;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(10, _ret_val);
	ASSERT_EQ(3, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_005)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 4;
	subfunction_001_return_value[3] = 20;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(20, _ret_val);
	ASSERT_EQ(4, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_006)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 5;
	subfunction_001_return_value[4] = 30;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(30, _ret_val);
	ASSERT_EQ(5, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_007)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 6;
	subfunction_001_return_value[5] = 40;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(40, _ret_val);
	ASSERT_EQ(6, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_008)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 7;
	subfunction_001_return_value[6] = 50;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(50, _ret_val);
	ASSERT_EQ(7, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_009)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 8;
	subfunction_001_return_value[7] = 60;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(60, _ret_val);
	ASSERT_EQ(8, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_010)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 9;
	subfunction_001_return_value[8] = 70;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(70, _ret_val);
	ASSERT_EQ(9, subfunction_001_called_count);
}

TEST_F(sample_function_002_004_utest, sample_function_002_004_utest_011)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 10;
	subfunction_001_return_value[9] = 80;

	int _ret_val = sample_function_002_004(input1);

	ASSERT_EQ(80, _ret_val);
	ASSERT_EQ(10, subfunction_001_called_count);
}

