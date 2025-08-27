namespace UnityEngine.U2D.Common.UTess;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(ArrayDebugView`1))]
[DefaultMember("Item")]
internal struct Array : IDisposable
{
	internal NativeArray<T> m_Array; //Field offset: 0x0
	internal int m_MaxSize; //Field offset: 0x0
	internal Allocator m_AllocLabel; //Field offset: 0x0
	internal NativeArrayOptions m_Options; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 40
	}

	public T Item
	{
		 get { } //Length: 10
		 set { } //Length: 88
	}

	public int Length
	{
		 get { } //Length: 13
	}

	public int MaxSize
	{
		 get { } //Length: 94
	}

	public Void* UnsafePtr
	{
		 get { } //Length: 70
	}

	public Void* UnsafeReadOnlyPtr
	{
		 get { } //Length: 70
	}

	public Array`1(int length, int maxSize, Allocator allocMode, NativeArrayOptions options) { }

	public override void Dispose() { }

	public bool get_IsCreated() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public int get_MaxSize() { }

	public Void* get_UnsafePtr() { }

	public Void* get_UnsafeReadOnlyPtr() { }

	private void ResizeIfRequired(int index) { }

	public void set_Item(int index, T value) { }

}

