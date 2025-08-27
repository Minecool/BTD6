namespace UnityEngine.U2D.Common.UTess;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(ArraySliceDebugView`1))]
[DefaultMember("Item")]
internal struct ArraySlice : IEquatable<ArraySlice`1<T>>
{
	[NativeDisableUnsafePtrRestriction]
	internal Byte* m_Buffer; //Field offset: 0x0
	internal int m_Stride; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 66
		[WriteAccessRequired]
		 set { } //Length: 80
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public ArraySlice`1(NativeArray<T> array, int start, int length) { }

	public override bool Equals(ArraySlice<T> other) { }

	public virtual bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public virtual int GetHashCode() { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

}

