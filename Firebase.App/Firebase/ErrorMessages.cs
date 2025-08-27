namespace Firebase;

internal class ErrorMessages
{
	private static string DEPENDENCY_NOT_FOUND_ERROR_ANDROID; //Field offset: 0x0
	private static string DEPENDENCY_NOT_FOUND_ERROR_IOS; //Field offset: 0x8
	private static string DEPENDENCY_NOT_FOUND_ERROR_GENERIC; //Field offset: 0x10
	private static string DLL_NOT_FOUND_ERROR_ANDROID; //Field offset: 0x18
	private static string DLL_NOT_FOUND_ERROR_IOS; //Field offset: 0x20
	private static string DLL_NOT_FOUND_ERROR_GENERIC; //Field offset: 0x28

	internal static string DependencyNotFoundErrorMessage
	{
		internal get { } //Length: 187
	}

	internal static string DllNotFoundExceptionErrorMessage
	{
		internal get { } //Length: 210
	}

	private static ErrorMessages() { }

	internal static string get_DependencyNotFoundErrorMessage() { }

	internal static string get_DllNotFoundExceptionErrorMessage() { }

}

