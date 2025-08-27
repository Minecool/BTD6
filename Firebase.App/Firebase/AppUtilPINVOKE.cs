namespace Firebase;

internal class AppUtilPINVOKE
{
	internal class SWIGExceptionHelper
	{
		internal sealed class ExceptionArgumentDelegate : MulticastDelegate
		{

			public ExceptionArgumentDelegate(object object, IntPtr method) { }

			public override void Invoke(string message, string paramName) { }

		}

		internal sealed class ExceptionDelegate : MulticastDelegate
		{

			public ExceptionDelegate(object object, IntPtr method) { }

			public override void Invoke(string message) { }

		}

		private static ExceptionDelegate applicationDelegate; //Field offset: 0x0
		private static ExceptionDelegate arithmeticDelegate; //Field offset: 0x8
		private static ExceptionDelegate divideByZeroDelegate; //Field offset: 0x10
		private static ExceptionDelegate indexOutOfRangeDelegate; //Field offset: 0x18
		private static ExceptionDelegate invalidCastDelegate; //Field offset: 0x20
		private static ExceptionDelegate invalidOperationDelegate; //Field offset: 0x28
		private static ExceptionDelegate ioDelegate; //Field offset: 0x30
		private static ExceptionDelegate nullReferenceDelegate; //Field offset: 0x38
		private static ExceptionDelegate outOfMemoryDelegate; //Field offset: 0x40
		private static ExceptionDelegate overflowDelegate; //Field offset: 0x48
		private static ExceptionDelegate systemDelegate; //Field offset: 0x50
		private static ExceptionArgumentDelegate argumentDelegate; //Field offset: 0x58
		private static ExceptionArgumentDelegate argumentNullDelegate; //Field offset: 0x60
		private static ExceptionArgumentDelegate argumentOutOfRangeDelegate; //Field offset: 0x68

		private static SWIGExceptionHelper() { }

		public SWIGExceptionHelper() { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName) { }

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName) { }

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message) { }

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message) { }

		public static void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

		public static void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	}

	internal class SWIGPendingException
	{
		[ThreadStatic]
		private static Exception pendingException; //Field offset: 0x80000000
		private static int numExceptionsPending; //Field offset: 0x0
		private static object exceptionsLock; //Field offset: 0x8

		public static bool Pending
		{
			 get { } //Length: 135
		}

		private static SWIGPendingException() { }

		public static bool get_Pending() { }

		public static Exception Retrieve() { }

		public static void Set(Exception e) { }

	}

	internal class SWIGStringHelper
	{
		internal sealed class SWIGStringDelegate : MulticastDelegate
		{

			public SWIGStringDelegate(object object, IntPtr method) { }

			public override string Invoke(string message) { }

		}

		private static SWIGStringDelegate stringDelegate; //Field offset: 0x0

		private static SWIGStringHelper() { }

		public SWIGStringHelper() { }

		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString) { }

		public static void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	}

	protected static SWIGExceptionHelper swigExceptionHelper; //Field offset: 0x0
	protected static SWIGStringHelper swigStringHelper; //Field offset: 0x8

	private static AppUtilPINVOKE() { }

	public static void AppEnableLogCallback(bool jarg1) { }

	public static void delete_StringStringMap(HandleRef jarg1) { }

	public static void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	public static IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	public static string FirebaseApp_DefaultName_get() { }

	internal static int FirebaseApp_GetLogLevelInternal() { }

	internal static void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	public static string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	internal static void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	internal static void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	public static bool GetEnabledAppCallbackByName(string jarg1) { }

	public static IntPtr new_StringStringMap__SWIG_0() { }

	public static void PollCallbacks() { }

	public static void SetEnabledAllAppCallbacks(bool jarg1) { }

	public static void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	public static void SetLogFunction(LogMessageDelegate jarg1) { }

	public static void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	public static void StringStringMap_Clear(HandleRef jarg1) { }

	public static bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	public static IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	public static void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	public static string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	public static string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	public static bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	public static void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	public static uint StringStringMap_size(HandleRef jarg1) { }

}

