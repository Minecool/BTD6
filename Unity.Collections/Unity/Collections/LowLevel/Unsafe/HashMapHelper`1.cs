namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
internal struct HashMapHelper
{
	[NativeDisableUnsafePtrRestriction]
	internal Byte* Ptr; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal TKey* Keys; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal Int32* Next; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal Int32* Buckets; //Field offset: 0x0
	internal int Count; //Field offset: 0x0
	internal int Capacity; //Field offset: 0x0
	internal int Log2MinGrowth; //Field offset: 0x0
	internal int BucketCapacity; //Field offset: 0x0
	internal int AllocatedIndex; //Field offset: 0x0
	internal int FirstFreeIdx; //Field offset: 0x0
	internal int SizeOfTValue; //Field offset: 0x0
	internal AllocatorHandle Allocator; //Field offset: 0x0

	internal bool IsCreated
	{
		[IsReadOnly]
		internal get { } //Length: 8
	}

	internal static HashMapHelper<TKey>* Alloc(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	internal int CalcCapacityCeilPow2(int capacity) { }

	internal static int CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, out int outKeyOffset, out int outNextOffset, out int outBucketOffset) { }

	internal void Clear() { }

	internal void Dispose() { }

	internal int Find(TKey key) { }

	internal static void Free(HashMapHelper<TKey>* data) { }

	[IsReadOnly]
	internal bool get_IsCreated() { }

	private int GetBucket(in TKey key) { }

	internal static int GetBucketSize(int capacity) { }

	internal void Init(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	internal void Resize(int newCapacity) { }

	internal void ResizeExact(int newCapacity, int newBucketCapacity) { }

	internal int TryAdd(in TKey key) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	internal bool TryGetValue(TKey key, out TValue item) { }

}

