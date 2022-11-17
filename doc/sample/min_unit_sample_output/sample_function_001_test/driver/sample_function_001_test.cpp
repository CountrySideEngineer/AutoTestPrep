#include <stdio.h>
#include <windows.h>
#include "min_unit.h"
#include "UserHeader.h"
//No global variables are refered by function sample_function_001.

//Test target function declare.
int sample_function_001(int input1, int input2);

//Initialize test stub buffers.
void sample_function_001_utest_SetUp()
{
}


static char* sample_function_001_utest_001()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 0;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(0 == _ret_val);
}

static char* sample_function_001_utest_002()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 1;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_003()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 2;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(2 == _ret_val);
}

static char* sample_function_001_utest_004()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 3;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(3 == _ret_val);
}

static char* sample_function_001_utest_005()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 0;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_006()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 1;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(0 == _ret_val);
}

static char* sample_function_001_utest_007()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 2;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_008()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 1;
	input2 = 3;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(2 == _ret_val);
}

static char* sample_function_001_utest_009()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 0;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(2 == _ret_val);
}

static char* sample_function_001_utest_010()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 1;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_011()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 2;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(0 == _ret_val);
}

static char* sample_function_001_utest_012()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 2;
	input2 = 3;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_013()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 0;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(3 == _ret_val);
}

static char* sample_function_001_utest_014()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 1;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(2 == _ret_val);
}

static char* sample_function_001_utest_015()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 2;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(1 == _ret_val);
}

static char* sample_function_001_utest_016()
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 3;
	input2 = 3;

	//Initialize stub parameters.
	sample_function_001_utest_SetUp();

	int _ret_val = sample_function_001(input1, input2);

	mu_assert(0 == _ret_val);
}

char* sample_function_001_utest_run_all()
{
	mu_run_test("sample_function_001_utest_001", sample_function_001_utest_001);
	mu_run_test("sample_function_001_utest_002", sample_function_001_utest_002);
	mu_run_test("sample_function_001_utest_003", sample_function_001_utest_003);
	mu_run_test("sample_function_001_utest_004", sample_function_001_utest_004);
	mu_run_test("sample_function_001_utest_005", sample_function_001_utest_005);
	mu_run_test("sample_function_001_utest_006", sample_function_001_utest_006);
	mu_run_test("sample_function_001_utest_007", sample_function_001_utest_007);
	mu_run_test("sample_function_001_utest_008", sample_function_001_utest_008);
	mu_run_test("sample_function_001_utest_009", sample_function_001_utest_009);
	mu_run_test("sample_function_001_utest_010", sample_function_001_utest_010);
	mu_run_test("sample_function_001_utest_011", sample_function_001_utest_011);
	mu_run_test("sample_function_001_utest_012", sample_function_001_utest_012);
	mu_run_test("sample_function_001_utest_013", sample_function_001_utest_013);
	mu_run_test("sample_function_001_utest_014", sample_function_001_utest_014);
	mu_run_test("sample_function_001_utest_015", sample_function_001_utest_015);
	mu_run_test("sample_function_001_utest_016", sample_function_001_utest_016);

	return 0;
}

