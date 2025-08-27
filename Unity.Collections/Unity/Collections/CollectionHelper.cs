namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class CollectionHelper
{
	[BurstCompile]
	internal struct DummyJob : IJob
	{

		public override void Execute() { }

	}


	public static int Align(int size, int alignmentPowerOfTwo) { }

	internal static int AssumePositive(int value) { }

	public static uint Hash(Void* ptr, int bytes) { }

	public static int Log2Floor(int value) { }

	internal static bool ShouldDeallocate(AllocatorHandle allocator) { }

}

