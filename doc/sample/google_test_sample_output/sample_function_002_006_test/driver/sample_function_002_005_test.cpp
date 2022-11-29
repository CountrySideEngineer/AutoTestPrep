/*
 *	sample_function_002_006 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_002_005_test.h"
#include "sample_function_002_006_stub.h"
//No global variables are refered by function sample_function_002_006.

//Test target function declare
int sample_function_002_006(int input1);

//Initialize test stub by calling methods to initialize them.
void sample_function_002_006_utest::SetUp()
{
	subfunction_002_init();
}


TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_001)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 0;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(0, subfunction_002_called_count);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_002)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 1;
	subfunction_002_input1_value_size[0] = 1;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(1, _ret_val);
	ASSERT_EQ(1, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_003)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 2;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(2, _ret_val);
	ASSERT_EQ(2, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_004)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 3;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(3, _ret_val);
	ASSERT_EQ(3, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_005)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 4;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(4, _ret_val);
	ASSERT_EQ(4, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_006)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 5;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(5, _ret_val);
	ASSERT_EQ(5, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_007)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 6;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;
	subfunction_002_input1_value_size[5] = 6;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(6, _ret_val);
	ASSERT_EQ(6, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
	ASSERT_EQ(0, subfunction_002_input1_value[5][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[5][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[5][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[5][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[5][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[5][5]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_008)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 7;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;
	subfunction_002_input1_value_size[5] = 6;
	subfunction_002_input1_value_size[6] = 7;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(7, _ret_val);
	ASSERT_EQ(7, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
	ASSERT_EQ(0, subfunction_002_input1_value[5][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[5][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[5][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[5][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[5][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[5][5]);
	ASSERT_EQ(0, subfunction_002_input1_value[6][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[6][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[6][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[6][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[6][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[6][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[6][6]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_009)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 8;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;
	subfunction_002_input1_value_size[5] = 6;
	subfunction_002_input1_value_size[6] = 7;
	subfunction_002_input1_value_size[7] = 8;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(8, _ret_val);
	ASSERT_EQ(8, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
	ASSERT_EQ(0, subfunction_002_input1_value[5][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[5][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[5][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[5][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[5][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[5][5]);
	ASSERT_EQ(0, subfunction_002_input1_value[6][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[6][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[6][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[6][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[6][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[6][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[6][6]);
	ASSERT_EQ(0, subfunction_002_input1_value[7][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[7][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[7][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[7][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[7][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[7][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[7][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[7][7]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_010)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 9;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;
	subfunction_002_input1_value_size[5] = 6;
	subfunction_002_input1_value_size[6] = 7;
	subfunction_002_input1_value_size[7] = 8;
	subfunction_002_input1_value_size[8] = 9;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(9, _ret_val);
	ASSERT_EQ(9, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
	ASSERT_EQ(0, subfunction_002_input1_value[5][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[5][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[5][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[5][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[5][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[5][5]);
	ASSERT_EQ(0, subfunction_002_input1_value[6][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[6][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[6][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[6][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[6][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[6][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[6][6]);
	ASSERT_EQ(0, subfunction_002_input1_value[7][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[7][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[7][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[7][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[7][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[7][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[7][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[7][7]);
	ASSERT_EQ(0, subfunction_002_input1_value[8][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[8][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[8][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[8][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[8][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[8][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[8][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[8][7]);
	ASSERT_EQ(8, subfunction_002_input1_value[8][8]);
}

TEST_F(sample_function_002_006_utest, sample_function_002_006_utest_011)
{
	//Declare argument for target
	int input1;

	//Setup test parameters.
	input1 = 10;
	subfunction_002_input1_value_size[0] = 1;
	subfunction_002_input1_value_size[1] = 2;
	subfunction_002_input1_value_size[2] = 3;
	subfunction_002_input1_value_size[3] = 4;
	subfunction_002_input1_value_size[4] = 5;
	subfunction_002_input1_value_size[5] = 6;
	subfunction_002_input1_value_size[6] = 7;
	subfunction_002_input1_value_size[7] = 8;
	subfunction_002_input1_value_size[8] = 9;
	subfunction_002_input1_value_size[9] = 10;

	int _ret_val = sample_function_002_006(input1);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(10, _ret_val);
	ASSERT_EQ(10, subfunction_002_called_count);
	ASSERT_EQ(0, subfunction_002_input1_value[0][0]);
	ASSERT_EQ(0, subfunction_002_input1_value[1][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[1][1]);
	ASSERT_EQ(0, subfunction_002_input1_value[2][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[2][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[2][2]);
	ASSERT_EQ(0, subfunction_002_input1_value[3][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[3][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[3][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[3][3]);
	ASSERT_EQ(0, subfunction_002_input1_value[4][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[4][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[4][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[4][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[4][4]);
	ASSERT_EQ(0, subfunction_002_input1_value[5][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[5][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[5][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[5][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[5][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[5][5]);
	ASSERT_EQ(0, subfunction_002_input1_value[6][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[6][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[6][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[6][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[6][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[6][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[6][6]);
	ASSERT_EQ(0, subfunction_002_input1_value[7][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[7][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[7][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[7][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[7][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[7][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[7][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[7][7]);
	ASSERT_EQ(0, subfunction_002_input1_value[8][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[8][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[8][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[8][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[8][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[8][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[8][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[8][7]);
	ASSERT_EQ(8, subfunction_002_input1_value[8][8]);
	ASSERT_EQ(0, subfunction_002_input1_value[9][0]);
	ASSERT_EQ(1, subfunction_002_input1_value[9][1]);
	ASSERT_EQ(2, subfunction_002_input1_value[9][2]);
	ASSERT_EQ(3, subfunction_002_input1_value[9][3]);
	ASSERT_EQ(4, subfunction_002_input1_value[9][4]);
	ASSERT_EQ(5, subfunction_002_input1_value[9][5]);
	ASSERT_EQ(6, subfunction_002_input1_value[9][6]);
	ASSERT_EQ(7, subfunction_002_input1_value[9][7]);
	ASSERT_EQ(8, subfunction_002_input1_value[9][8]);
	ASSERT_EQ(9, subfunction_002_input1_value[9][9]);
}

