namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeParallelHashMapData
{
	internal Byte* values; //Field offset: 0x0
	internal Byte* keys; //Field offset: 0x8
	internal Byte* next; //Field offset: 0x10
	internal Byte* buckets; //Field offset: 0x18
	internal int keyCapacity; //Field offset: 0x20
	internal int bucketCapacityMask; //Field offset: 0x24
	internal int allocatedIndexLength; //Field offset: 0x28

	internal Int32* firstFreeTLS
	{
		internal get { } //Length: 5
	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	internal static void AllocateHashMap(int length, int bucketLength, AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	internal static int CalculateDataSize(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) { }

	internal static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorHandle allocator) { }

	internal Int32* get_firstFreeTLS() { }

	internal static int GetBucketSize(int capacity) { }

	internal static int GetCount(UnsafeParallelHashMapData* data) { }

	internal static int GrowCapacity(int capacity) { }

	internal static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	internal static bool MoveNextSearch(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	internal static void ReallocateHashMap(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorHandle label) { }

}

