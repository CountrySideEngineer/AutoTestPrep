/*
 *	sample_function_002 test driver source code.
 */
#include <stdio.h>
#include <windows.h>
#include "min_unit.h"
#include "UserHeader.h"
#include "sample_function_002_stub.h"
//No global variables are refered by function sample_function_002.

//Test target function declare.
int sample_function_002(int input1, int input2);

//Initialize test stub buffers.
void sample_function_002_utest_SetUp()
{
	subFuncA_002_init();
}


static char* sample_function_002_utest_001()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;
	subFuncA_002_return_value[0] = 1;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(1 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(0 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_002()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 1;
	subFuncA_002_return_value[0] = 2;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(2 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(1 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_003()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 2;
	subFuncA_002_return_value[0] = 4;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(4 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(2 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_004()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 3;
	subFuncA_002_return_value[0] = 8;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(8 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_005()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;
	subFuncA_002_return_value[0] = 1;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(1 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(1 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_006()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 1;
	subFuncA_002_return_value[0] = 2;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(2 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(1 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_007()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 2;
	subFuncA_002_return_value[0] = 4;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(4 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(2 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_008()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 3;
	subFuncA_002_return_value[0] = 8;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(8 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_009()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;
	subFuncA_002_return_value[0] = 1;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(1 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(2 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_010()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 1;
	subFuncA_002_return_value[0] = 2;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(2 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(2 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_011()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 2;
	subFuncA_002_return_value[0] = 4;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(4 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(2 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_012()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 3;
	subFuncA_002_return_value[0] = 8;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(8 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_013()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;
	subFuncA_002_return_value[0] = 1;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(1 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_014()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 1;
	subFuncA_002_return_value[0] = 2;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(2 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_015()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 2;
	subFuncA_002_return_value[0] = 4;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(4 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

static char* sample_function_002_utest_016()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 3;
	subFuncA_002_return_value[0] = 8;

	//Initialize stub parameters.
	sample_function_002_utest_SetUp();

	int _ret_val = sample_function_002(input1, input2);

	//Check the test result
	//by comparing the output with the expected value.
	mu_assert(8 == _ret_val);
	mu_assert(1 == subFuncA_002_called_count);
	mu_assert(3 == subFuncA_002_subInput1[0]);
}

char* sample_function_002_utest_run_all()
{
	mu_run_test("sample_function_002_utest_001", sample_function_002_utest_001);
	mu_run_test("sample_function_002_utest_002", sample_function_002_utest_002);
	mu_run_test("sample_function_002_utest_003", sample_function_002_utest_003);
	mu_run_test("sample_function_002_utest_004", sample_function_002_utest_004);
	mu_run_test("sample_function_002_utest_005", sample_function_002_utest_005);
	mu_run_test("sample_function_002_utest_006", sample_function_002_utest_006);
	mu_run_test("sample_function_002_utest_007", sample_function_002_utest_007);
	mu_run_test("sample_function_002_utest_008", sample_function_002_utest_008);
	mu_run_test("sample_function_002_utest_009", sample_function_002_utest_009);
	mu_run_test("sample_function_002_utest_010", sample_function_002_utest_010);
	mu_run_test("sample_function_002_utest_011", sample_function_002_utest_011);
	mu_run_test("sample_function_002_utest_012", sample_function_002_utest_012);
	mu_run_test("sample_function_002_utest_013", sample_function_002_utest_013);
	mu_run_test("sample_function_002_utest_014", sample_function_002_utest_014);
	mu_run_test("sample_function_002_utest_015", sample_function_002_utest_015);
	mu_run_test("sample_function_002_utest_016", sample_function_002_utest_016);

	return 0;
}

