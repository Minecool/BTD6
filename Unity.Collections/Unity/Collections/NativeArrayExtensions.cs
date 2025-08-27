namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeArrayExtensions
{

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	public static bool Contains(ReadOnly<T> array, U value) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	public static int IndexOf(Void* ptr, int length, U value) { }

}

