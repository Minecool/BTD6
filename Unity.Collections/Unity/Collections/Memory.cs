namespace Unity.Collections;

[BurstCompatible]
internal struct Memory
{
	[BurstCompatible]
	public struct Unmanaged
	{
		[BurstCompatible]
		public struct Array
		{

			private static Void* CustomResize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			private static bool IsCustom(AllocatorHandle allocator) { }

			internal static Void* Resize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
			internal static T* Resize(T* oldPointer, long oldCount, long newCount, AllocatorHandle allocator) { }

		}


		internal static Void* Allocate(long size, int align, AllocatorHandle allocator) { }

		internal static void Free(Void* pointer, AllocatorHandle allocator) { }

		[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
		internal static void Free(T* pointer, AllocatorHandle allocator) { }

	}


}

