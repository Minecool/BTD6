namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeAtomicCounter32
{
	public Int32* Counter; //Field offset: 0x0

	public UnsafeAtomicCounter32(Void* ptr) { }

	public int Add(int value) { }

}

