namespace Unity.Collections;

[DefaultMember("Item")]
internal struct UnmanagedArray : IDisposable
{
	private IntPtr m_pointer; //Field offset: 0x0
	private int m_length; //Field offset: 0x0
	private AllocatorHandle m_allocator; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 373
	}

	public override void Dispose() { }

	public T get_Item(int index) { }

}

