#include <stdio.h>
#include <windows.h>
#include "gtest/gtest.h"
#include "sample_function_004_test.h"
#include "sample_function_004_stub.h"
long outsideVariable;
extern short insideVariable;


//Test target function declare
int sample_function_004(int input1, int* input2);

void sample_function_004_utest::SetUp()
{
	subFuncA_init();
}


TEST_F(sample_function_004_utest, sample_function_004_utest_2)
{
	//Declare argument for target
	int input1;
	int input2;

	//Setup test parameters.
	input1 = 0;
	input2 = 2;

	int _ret_val = sample_function_004(input1, &input2);

	ASSERT_EQ(2, _ret_val);
}

