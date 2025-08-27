namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
public struct UnsafeText : IDisposable, IUTF8Bytes, INativeList<Byte>, IIndexable<Byte>
{
	internal UntypedUnsafeList m_UntypedListData; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 88
	}

	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 85
	}

	public override void Dispose() { }

	internal static void Free(UnsafeText* data) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public override int get_Length() { }

	public override Byte* GetUnsafePtr() { }

	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public virtual string ToString() { }

}

