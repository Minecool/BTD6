namespace Firebase.Crashlytics;

internal class CrashlyticsInternalPINVOKE
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

		internal static void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

		internal static void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	}

	internal class SWIGPendingException
	{
		[ThreadStatic]
		private static Exception pendingException; //Field offset: 0x80000000
		private static int numExceptionsPending; //Field offset: 0x0
		private static object exceptionsLock; //Field offset: 0x8

		private static SWIGPendingException() { }

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

		internal static void SWIGRegisterStringCallback_CrashlyticsInternal(SWIGStringDelegate stringDelegate) { }

	}

	protected static SWIGExceptionHelper swigExceptionHelper; //Field offset: 0x0
	protected static SWIGStringHelper swigStringHelper; //Field offset: 0x8

	private static CrashlyticsInternalPINVOKE() { }

	public static void delete_FirebaseCrashlyticsFrame(HandleRef jarg1) { }

	public static void delete_StackFrames(HandleRef jarg1) { }

	public static void FirebaseCrashlyticsFrame_fileName_set(HandleRef jarg1, string jarg2) { }

	public static void FirebaseCrashlyticsFrame_library_set(HandleRef jarg1, string jarg2) { }

	public static void FirebaseCrashlyticsFrame_lineNumber_set(HandleRef jarg1, string jarg2) { }

	public static void FirebaseCrashlyticsFrame_symbol_set(HandleRef jarg1, string jarg2) { }

	public static IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_0(HandleRef jarg1, out int jarg2) { }

	public static void FirebaseCrashlyticsInternal_LogException(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4) { }

	public static void FirebaseCrashlyticsInternal_LogExceptionAsFatal(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4) { }

	public static void FirebaseCrashlyticsInternal_SetCustomKey(HandleRef jarg1, string jarg2, string jarg3) { }

	public static IntPtr new_FirebaseCrashlyticsFrame() { }

	public static IntPtr new_StackFrames__SWIG_0() { }

	public static void StackFrames_Add(HandleRef jarg1, HandleRef jarg2) { }

	public static IntPtr StackFrames_getitem(HandleRef jarg1, int jarg2) { }

	public static uint StackFrames_size(HandleRef jarg1) { }

}

