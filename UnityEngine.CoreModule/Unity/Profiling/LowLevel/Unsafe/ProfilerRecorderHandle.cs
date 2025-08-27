namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerRecorderHandle
{
	internal readonly ulong handle; //Field offset: 0x0

	public bool Valid
	{
		 get { } //Length: 17
	}

	internal ProfilerRecorderHandle(ulong handle) { }

	public bool get_Valid() { }

	internal static ProfilerRecorderHandle GetByName(ProfilerCategory category, Char* name, int nameLen) { }

	[NativeMethod(IsThreadSafe = True)]
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, Byte* name, int nameLen) { }

	private static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, Byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	[NativeMethod(IsThreadSafe = True)]
	private static ProfilerRecorderHandle GetByName_Unsafe(ProfilerCategory category, Char* name, int nameLen) { }

	private static void GetByName_Unsafe_Injected(ref ProfilerCategory category, Char* name, int nameLen, out ProfilerRecorderHandle ret) { }

	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) { }

	[NativeMethod(IsThreadSafe = True)]
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) { }

	private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) { }

}

