namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
internal static class UnsafeTextExtensions
{

	[Extension]
	public static UnsafeList<Byte>& AsUnsafeListOfBytes(ref UnsafeText text) { }

	[Extension]
	public static UnsafeList<Byte> AsUnsafeListOfBytesRO(UnsafeText text) { }

}

