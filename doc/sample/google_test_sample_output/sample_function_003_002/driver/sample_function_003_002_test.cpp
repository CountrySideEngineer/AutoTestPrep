/*
 *	sample_function_003_002 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_003_002_test.h"
#include "sample_function_003_002_stub.h"
//No global variables are refered by function sample_function_003_002.

//Test target function declare
int sample_function_003_002(char * file_name);

//Initialize test stub by calling methods to initialize them.
void sample_function_003_002_utest::SetUp()
{
	fclose_init();
}


TEST_F(sample_function_003_002_utest, sample_function_003_002_utest_001)
{
	//Declare argument for target
	char _file_name[100];
	char* file_name;

	//Setup test parameters.
	file_name = "file_path";
	fopen_return_value[0] = &_file_data;
	fclose_return_value[0] = 0;

	int _ret_val = sample_function_003_002(file_name);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, fopen_called_count);
	ASSERT_EQ(1, fclose_called_count);
}

TEST_F(sample_function_003_002_utest, sample_function_003_002_utest_002)
{
	//Declare argument for target
	char _file_name[100];
	char* file_name;

	//Setup test parameters.
	file_name = "";
	fopen_return_value[0] = &_file_data;
	fclose_return_value[0] = 0;

	int _ret_val = sample_function_003_002(file_name);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, fopen_called_count);
	ASSERT_EQ(1, fclose_called_count);
}

TEST_F(sample_function_003_002_utest, sample_function_003_002_utest_003)
{
	//Declare argument for target
	char _file_name[100];
	char* file_name;

	//Setup test parameters.
	file_name = "file_path";
	fopen_return_value[0] = &_file_data;
	fclose_return_value[0] = 1;

	int _ret_val = sample_function_003_002(file_name);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, fopen_called_count);
	ASSERT_EQ(1, fclose_called_count);
}

TEST_F(sample_function_003_002_utest, sample_function_003_002_utest_004)
{
	//Declare argument for target
	char _file_name[100];
	char* file_name;

	//Setup test parameters.
	file_name = "file_path";
	fopen_return_value[0] = &_file_data;
	fclose_return_value[0] = -1;

	int _ret_val = sample_function_003_002(file_name);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, fopen_called_count);
	ASSERT_EQ(1, fclose_called_count);
}

TEST_F(sample_function_003_002_utest, sample_function_003_002_utest_005)
{
	//Declare argument for target
	char _file_name[100];
	char* file_name;

	//Setup test parameters.
	file_name = "file_path";
	fopen_return_value[0] = NULL;

	int _ret_val = sample_function_003_002(file_name);

	//Check the test result by comparing the output with the expected value.
	ASSERT_EQ(0, _ret_val);
	ASSERT_EQ(1, fopen_called_count);
	ASSERT_EQ(1, fclose_called_count);
}

