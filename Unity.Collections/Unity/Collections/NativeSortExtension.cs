namespace Unity.Collections;

[BurstCompatible]
[Extension]
public static class NativeSortExtension
{
	[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	internal struct DefaultComparer : IComparer<T>
	{

		public override int Compare(T x, T y) { }

	}


	private static void Heapify(Void* array, int i, int n, int lo, U comp) { }

	private static void HeapSort(Void* array, int lo, int hi, U comp) { }

	private static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	internal static void IntroSort(Void* array, int length, U comp) { }

	private static void IntroSort(Void* array, int lo, int hi, int depth, U comp) { }

	private static int Partition(Void* array, int lo, int hi, U comp) { }

	[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	[Extension]
	public static void Sort(NativeList<T> list, U comp) { }

	private static void Swap(Void* array, int lhs, int rhs) { }

	private static void SwapIfGreaterWithItems(Void* array, int lhs, int rhs, U comp) { }

}

