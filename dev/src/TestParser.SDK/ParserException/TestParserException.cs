﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.ParserException
{
	public class TestParserException : Exception
	{
		/// <summary>
		/// Error code.
		/// </summary>
		public ushort ErrorCode { get; protected set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestParserException() : base()
		{
			this.ErrorCode = 0xFFFF;
		}

		/// <summary>
		/// Constructor with message.
		/// </summary>
		/// <param name="message">Error message</param>
		public TestParserException(string message) : base(message)
		{
			this.ErrorCode = 0xFFFF;
		}

		/// <summary>
		/// Constructor with error code and message
		/// </summary>
		/// <param name="errCode">Error code.</param>
		/// <param name="message">Error message</param>
		/// <remarks>Message is empty in default</remarks>
		public TestParserException(ushort errCode, string message = "") : base(message)
		{
			ErrorCode = errCode;
		}

		/// <summary>
		/// Constructor with error code and message.
		/// </summary>
		/// <param name="errCode">Error code</param>
		/// <param name="message">Error message</param>
		public TestParserException(Code errCode, string message = "") : base(message)
		{
			try
			{
				ErrorCode = Convert.ToUInt16(errCode);
			}
			catch (Exception)
			{
				ErrorCode = 0xFFFF;
			}
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="message">Error message.</param>
		/// <param name="innerException">Inner exception.</param>
		public TestParserException(string message, Exception innerException) 
			: base(message, innerException)
		{
			this.ErrorCode = 0xFFFF;
		}

		public enum Code
		{
			PARSER_ERROR_FILE_CAN_NOT_OPEN = 0x1001,
			PARSER_ERROR_TEST_FUNCTION_LIST_SHEET_NOT_FOUND,
			PARSER_ERROR_TEST_FUNCTION_TABLE_NOT_FOUND,
			PARSER_ERROR_TEST_FUNCTION_TABLE_FORMAT_ERROR,
			PARSER_ERROR_INVALID_DATA_INPUT_IN_TEST_FUNCTION_TABLE,
			PARSER_ERROR_UNEXPECTED_ERROR_DETECTED_IN_FUNCTION_LIST,
			PARSER_ERROR_NO_TEST_FUNCTION_SET,
			PARSER_ERROR_TEST_FUNCTION_TABLE_NAME_INVALID,
			PARSER_ERROR_TEST_FUNCTION_SHEET_NOT_FOUND,
			PARSER_ERROR_TEST_FUNCTION_DATA_INVALID,
			PARSER_ERROR_TEST_FUNCTION_ARGUMENT_DATA_INVALID,
			PARSER_ERROR_TEST_SUBFUNCTION_DATA_INVALID,
			PARSER_ERROR_TEST_SUBFUNCTION_ARGUMENT_DATA_INVALID,
			PARSER_ERROR_TEST_FUNCTION_VARIABLE_DATA_INVALID,
			PARSER_ERROR_INTERNAL_VARIABLE_DATA_INVALID,
			PARSER_ERROR_EXTERNAL_VARIABLE_DATA_INVALID,
			PARSER_ERROR_UNEXPECTED_ERROR_DETECTED_IN_FUNCTION_TABLE,
			PARSER_ERROR_TEST_CASE_SHEET_NOT_FOUND,
			PARSER_ERROR_TEST_CASE_TABLE_NAME_INVALID,
			PARSRE_ERROR_TEST_CASE_TABLE_NOT_FOUND,
			PARSRE_ERROR_TEST_CASE_TABLE_CONFIGURATION_INVALID,
			PARSRE_ERROR_TEST_CASE_TABLE_PARSER_CONFIGURATION_INVALID,
			PARSER_ERROR_TEST_INPUT_OUTPUT_INVALID,
			PARSER_ERROR_TEST_INPUT_OUTPUT_DESCRIPTION_INVALID,
			PARSER_ERROR_TEST_VARIABLE_NAME_INVALID,
			PARSER_ERROR_TEST_REPRESENTATIVE_VALUE_INVALID,
			PARSER_ERROR_TEST_VALUE_NOT_SELECTED,
			PARSER_ERROR_UNEXPECTED_ERROR_DETECTED_IN_TEST_CASE_TABLE,
			TEST_PARSE_FAILED = 0xFFFF
		};
	}
}
