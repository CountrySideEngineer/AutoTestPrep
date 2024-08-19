using Logger;
using TestReader.Model;
using TestReader.Reader;

namespace TestReader_FunctionReader_ctest
{
	public class FunctionReader_test
	{
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			Log.AddLogger(new Logger.Console.DebugLog());
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void FunctionReader_Read_001_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_001";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_001"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.Arguments.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(data.Arguments.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_001(int input1, int input2)"));
		}

		[Test]
		public void FunctionReader_Read_001_002()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_002";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.Arguments.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(data.Arguments.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002(int * input1, int * input2)"));
		}

		[Test]
		public void FunctionReader_Read_001_003()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_003";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_003"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.Arguments.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(data.Arguments.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_003(int * input1, int * input2)"));
		}

		[Test]
		public void FunctionReader_Read_001_004()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_004";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_004"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.Arguments.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(data.Arguments.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.OUT));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_004(int * input1, int * input2)"));
		}

		[Test]
		public void FunctionReader_Read_001_005()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_005";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_005"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("VOID"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("VOID*"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.Arguments.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(data.Arguments.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(1).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_005(VOID * input1, int * input2)"));
		}

		[Test]
		public void FunctionReader_Read_002_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_001";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_001"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_001"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_001(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_001(int input1)"));
		}

		[Test]
		public void FunctionReader_Read_002_002()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_002";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_002"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_002"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_002(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_002(int * input1)"));
		}

		[Test]
		public void FunctionReader_Read_002_003()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_003";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_003"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_003"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.OUT));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_003(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_003(int * input1)"));
		}

		[Test]
		public void FunctionReader_Read_002_004()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_004";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_004"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_001"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_004(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_001(int input1)"));
		}

		[Test]
		public void FunctionReader_Read_002_005()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_005";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_005"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_002"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_005(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_002(int * input1)"));
		}

		[Test]
		public void FunctionReader_Read_002_006()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "sample_function_002_006";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_002_006"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("subfunction_003"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("int*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.OUT));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_002_006(int input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("int subfunction_003(int * input1)"));
		}

		[Test]
		public void FunctionReader_Read_003_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_003.xlsx";
			string sheetName = "sample_function_003_001";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_003_001"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("DWORD"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("DWORD"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(2));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("SetLastError"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("VOID"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("VOID"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("dwErrCode"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("DWORD"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("DWORD"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.ToString(), Is.EqualTo("int sample_function_003_001(DWORD input1)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("WINBASEAPI VOID WINAPI SetLastError(_In_ DWORD dwErrCode)"));
		}

		[Test]
		public void FunctionReader_Read_003_002()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_003.xlsx";
			string sheetName = "sample_function_003_002";

			var reader = new FunctionReader();
			Function data = reader.Read(testFilePath, sheetName);

			Assert.That(data.Name, Is.EqualTo("sample_function_003_002"));
			Assert.That(data.Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.Arguments.ElementAt(0).Name, Is.EqualTo("file_name"));
			Assert.That(data.Arguments.ElementAt(0).DataType, Is.EqualTo("char"));
			Assert.That(data.Arguments.ElementAt(0).ActualDataType, Is.EqualTo("char*"));
			Assert.That(data.Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.Count(), Is.EqualTo(2));
			Assert.That(data.SubFunctions.ElementAt(0).Name, Is.EqualTo("fopen"));
			Assert.That(data.SubFunctions.ElementAt(0).DataType, Is.EqualTo("FILE"));
			Assert.That(data.SubFunctions.ElementAt(0).ActualDataType, Is.EqualTo("FILE*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.Count(), Is.EqualTo(2));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name, Is.EqualTo("_FileName"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType, Is.EqualTo("char"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("char*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Name, Is.EqualTo("_Mode"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(1).DataType, Is.EqualTo("char"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(1).ActualDataType, Is.EqualTo("char*"));
			Assert.That(data.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Mode, Is.EqualTo(Parameter.ACCESS_MODE.IN));

			Assert.That(data.SubFunctions.ElementAt(1).Name, Is.EqualTo("fclose"));
			Assert.That(data.SubFunctions.ElementAt(1).DataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(1).ActualDataType, Is.EqualTo("int"));
			Assert.That(data.SubFunctions.ElementAt(1).Arguments.Count(), Is.EqualTo(1));
			Assert.That(data.SubFunctions.ElementAt(1).Arguments.ElementAt(0).Name, Is.EqualTo("_Stream"));
			Assert.That(data.SubFunctions.ElementAt(1).Arguments.ElementAt(0).DataType, Is.EqualTo("FILE"));
			Assert.That(data.SubFunctions.ElementAt(1).Arguments.ElementAt(0).ActualDataType, Is.EqualTo("FILE*"));
			Assert.That(data.SubFunctions.ElementAt(1).Arguments.ElementAt(0).Mode, Is.EqualTo(Parameter.ACCESS_MODE.BOTH));

			Assert.That(data.ToString(), Is.EqualTo("int sample_function_003_002(char * file_name)"));
			Assert.That(data.SubFunctions.ElementAt(0).ToString(), Is.EqualTo("_Check_return_ _CRT_INSECURE_DEPRECATE(fopen_s) _ACRTIMP FILE * __cdecl fopen(_In_z_ char const * _FileName, _In_z_ char const * _Mode)"));
			Assert.That(data.SubFunctions.ElementAt(1).ToString(), Is.EqualTo("_Success_(return != -1) _Check_return_opt_ _ACRTIMP int __cdecl fclose(_Inout_ FILE * _Stream)"));
		}
	}
}