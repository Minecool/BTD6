namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle>
{
	internal ulong jobGroup; //Field offset: 0x0
	internal int version; //Field offset: 0x8

	public bool IsCompleted
	{
		 get { } //Length: 51
	}

	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, out JobHandle ret) { }

	public void Complete() { }

	public override bool Equals(JobHandle other) { }

	public bool get_IsCompleted() { }

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	public static void ScheduleBatchedJobs() { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

}

