#include <stdio.h>
#include <windows.h>
#include "min_unit.h"
#include "UserHeader.h"
//No global variables are refered by function sample_function_003.

//Test target function declare.
int sample_function_003(int input1, int* input2, SHORT input3);

//Initialize test stub buffers.
void sample_function_003_utest_SetUp()
{
}


static char* sample_function_003_utest_001()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 1;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(10 == input2);
}

static char* sample_function_003_utest_002()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 2;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(20 == input2);
}

static char* sample_function_003_utest_003()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 0;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 3;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(30 == input2);
}

static char* sample_function_003_utest_004()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 1;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(0 == input2);
}

static char* sample_function_003_utest_005()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 2;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(10 == input2);
}

static char* sample_function_003_utest_006()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 1;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 3;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(20 == input2);
}

static char* sample_function_003_utest_007()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 1;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(10 == input2);
}

static char* sample_function_003_utest_008()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 2;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(0 == input2);
}

static char* sample_function_003_utest_009()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 2;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 3;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(1 == _ret_val);
	mu_assert(10 == input2);
}

static char* sample_function_003_utest_010()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 1;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(20 == input2);
}

static char* sample_function_003_utest_011()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 2;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(10 == input2);
}

static char* sample_function_003_utest_012()
{
	//Declare argument for target
	int input1;
	int _input2[100];
	int* input2;
	SHORT input3;

	//Setup test parameters.
	input1 = 3;
	_input2[0] = 0;
	input2 = &_input2[0];
	input3 = 3;

	//Initialize stub parameters.
	sample_function_003_utest_SetUp();

	int _ret_val = sample_function_003(input1, input2, input3);

	mu_assert(2 == _ret_val);
	mu_assert(0 == input2);
}

char* sample_function_003_utest_run_all()
{
	mu_run_test("sample_function_003_utest_001", sample_function_003_utest_001);
	mu_run_test("sample_function_003_utest_002", sample_function_003_utest_002);
	mu_run_test("sample_function_003_utest_003", sample_function_003_utest_003);
	mu_run_test("sample_function_003_utest_004", sample_function_003_utest_004);
	mu_run_test("sample_function_003_utest_005", sample_function_003_utest_005);
	mu_run_test("sample_function_003_utest_006", sample_function_003_utest_006);
	mu_run_test("sample_function_003_utest_007", sample_function_003_utest_007);
	mu_run_test("sample_function_003_utest_008", sample_function_003_utest_008);
	mu_run_test("sample_function_003_utest_009", sample_function_003_utest_009);
	mu_run_test("sample_function_003_utest_010", sample_function_003_utest_010);
	mu_run_test("sample_function_003_utest_011", sample_function_003_utest_011);
	mu_run_test("sample_function_003_utest_012", sample_function_003_utest_012);

	return 0;
}

