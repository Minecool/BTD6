namespace Unity.Jobs;

[Extension]
public static class IJobParallelForBatchExtensions
{
	public struct JobParallelForBatchProducer
	{
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			public ExecuteJobFunction(object object, IntPtr method) { }

			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		private static JobParallelForBatchProducer`1() { }

		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		internal static void Initialize() { }

	}


	public static void EarlyJobInit() { }

	private static IntPtr GetReflectionData() { }

	[Extension]
	public static JobHandle ScheduleBatch(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleParallel(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

}

