namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
internal struct UnsafeParallelHashMapBase
{

	internal static int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex) { }

	internal static void Clear(UnsafeParallelHashMapData* data) { }

	internal static void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex) { }

	internal static int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap) { }

	internal static void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it) { }

	internal static bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey>& it, ref TValue item) { }

	internal static bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorHandle allocation) { }

	internal static bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) { }

	internal static bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	internal static bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

