namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList128BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
public struct FixedList128Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[SerializeField]
	internal FixedBytes128Align8 data; //Field offset: 0x0

	internal Byte* buffer
	{
		[IsReadOnly]
		internal get { } //Length: 57
	}

	internal Byte* Buffer
	{
		[IsReadOnly]
		internal get { } //Length: 119
	}

	[CreateProperty]
	private IEnumerable<T> Elements
	{
		private get { } //Length: 54
	}

	internal ushort length
	{
		[IsReadOnly]
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	[CreateProperty]
	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 47
	}

	internal int LengthInBytes
	{
		internal get { } //Length: 105
	}

	public override int CompareTo(FixedList4096Bytes<T> other) { }

	public override int CompareTo(FixedList512Bytes<T> other) { }

	public override int CompareTo(FixedList32Bytes<T> other) { }

	public override int CompareTo(FixedList128Bytes<T> other) { }

	public override int CompareTo(FixedList64Bytes<T> other) { }

	public override bool Equals(FixedList32Bytes<T> other) { }

	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object obj) { }

	public override bool Equals(FixedList4096Bytes<T> other) { }

	public override bool Equals(FixedList512Bytes<T> other) { }

	public override bool Equals(FixedList128Bytes<T> other) { }

	public override bool Equals(FixedList64Bytes<T> other) { }

	[IsReadOnly]
	internal Byte* get_buffer() { }

	[IsReadOnly]
	internal Byte* get_Buffer() { }

	private IEnumerable<T> get_Elements() { }

	[IsReadOnly]
	internal ushort get_length() { }

	[IsReadOnly]
	public override int get_Length() { }

	internal int get_LengthInBytes() { }

	public virtual int GetHashCode() { }

	internal void set_length(ushort value) { }

	public override void set_Length(int value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray() { }

}

