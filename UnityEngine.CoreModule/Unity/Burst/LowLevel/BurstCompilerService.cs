namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
internal static class BurstCompilerService
{
	internal enum BurstLogType
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}


	[FreeFunction(IsThreadSafe = True)]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[FreeFunction(IsThreadSafe = True)]
	public static Void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[ThreadSafe]
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	[FreeFunction("DefaultBurstLogCallback", True)]
	public static void Log(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	public static void RuntimeLog(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

}

