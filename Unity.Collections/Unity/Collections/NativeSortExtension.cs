namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeSortExtension
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	internal struct DefaultComparer : IComparer<T>
	{

		public override int Compare(T x, T y) { }

	}


	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static int BinarySearch(T* ptr, int length, T value, U comp) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	public static int BinarySearch(NativeArray<T> array, T value) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static int BinarySearch(NativeArray<T> array, T value, U comp) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	public static int BinarySearch(ReadOnly<T> array, T value) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static int BinarySearch(ReadOnly<T> array, T value, U comp) { }

	private static void Heapify(Void* array, int i, int n, int lo, U comp) { }

	private static void HeapSort(Void* array, int lo, int hi, U comp) { }

	private static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	internal static void IntroSort(Void* array, int length, U comp) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	internal static void IntroSort_R(Void* array, int lo, int hi, int depth, U comp) { }

	private static int Partition(Void* array, int lo, int hi, U comp) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static void Sort(T* array, int length, U comp) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static void Sort(NativeList<T> list, U comp) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(NativeArray<T> array) { }

	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)}])]
	public static SortJob<T, U> SortJob(T* array, int length, U comp) { }

	private static void Swap(Void* array, int lhs, int rhs) { }

	private static void SwapIfGreaterWithItems(Void* array, int lhs, int rhs, U comp) { }

}

