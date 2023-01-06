/*
 *	sample_function_001 test driver main function source code.
 */
#include <stdio.h>
#include "min_unit.h"

int test_run = 0;

char* sample_function_001_utest_run_all();

int main()
{
	//Run all test.
	mu_run_all_test("sample_function_001_utest_run_all", sample_function_001_utest_run_all);

	return 0;
}
