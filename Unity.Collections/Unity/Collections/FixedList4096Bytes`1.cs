namespace Unity.Collections;

[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView`1))]
[DefaultMember("Item")]
public struct FixedList4096Bytes : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[SerializeField]
	internal ushort length; //Field offset: 0x0
	[SerializeField]
	internal FixedBytes4094 buffer; //Field offset: 0x0

	internal Byte* Buffer
	{
		internal get { } //Length: 58
	}

	public override T Item
	{
		 get { } //Length: 161
		 set { } //Length: 178
	}

	[CreateProperty]
	public override int Length
	{
		 get { } //Length: 4
	}

	internal int LengthInBytes
	{
		internal get { } //Length: 73
	}

	public override int CompareTo(FixedList4096Bytes<T> other) { }

	public override int CompareTo(FixedList32Bytes<T> other) { }

	public override int CompareTo(FixedList64Bytes<T> other) { }

	public override int CompareTo(FixedList128Bytes<T> other) { }

	public override int CompareTo(FixedList512Bytes<T> other) { }

	public override bool Equals(FixedList64Bytes<T> other) { }

	[NotBurstCompatible]
	public virtual bool Equals(object obj) { }

	public override bool Equals(FixedList4096Bytes<T> other) { }

	public override bool Equals(FixedList32Bytes<T> other) { }

	public override bool Equals(FixedList512Bytes<T> other) { }

	public override bool Equals(FixedList128Bytes<T> other) { }

	internal Byte* get_Buffer() { }

	public override T get_Item(int index) { }

	public override int get_Length() { }

	internal int get_LengthInBytes() { }

	public virtual int GetHashCode() { }

	public override void set_Item(int index, T value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

