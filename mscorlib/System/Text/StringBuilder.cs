namespace System.Text;

[DefaultMember("Chars")]
public sealed class StringBuilder : ISerializable
{
	internal const int DefaultCapacity = 16; //Field offset: 0x0
	private const string CapacityField = "Capacity"; //Field offset: 0x0
	private const string MaxCapacityField = "m_MaxCapacity"; //Field offset: 0x0
	private const string StringValueField = "m_StringValue"; //Field offset: 0x0
	private const string ThreadIDField = "m_currentThread"; //Field offset: 0x0
	internal const int MaxChunkSize = 8000; //Field offset: 0x0
	private const int IndexLimit = 1000000; //Field offset: 0x0
	private const int WidthLimit = 1000000; //Field offset: 0x0
	internal Char[] m_ChunkChars; //Field offset: 0x10
	internal StringBuilder m_ChunkPrevious; //Field offset: 0x18
	internal int m_ChunkLength; //Field offset: 0x20
	internal int m_ChunkOffset; //Field offset: 0x24
	internal int m_MaxCapacity; //Field offset: 0x28

	public int Capacity
	{
		 get { } //Length: 29
		 set { } //Length: 439
	}

	public char Chars
	{
		 get { } //Length: 200
		 set { } //Length: 278
	}

	public int Length
	{
		 get { } //Length: 7
		 set { } //Length: 640
	}

	public int MaxCapacity
	{
		 get { } //Length: 4
	}

	private Span<Char> RemainingCurrentChunk
	{
		private get { } //Length: 159
	}

	public StringBuilder() { }

	public StringBuilder(int capacity) { }

	public StringBuilder(string value) { }

	public StringBuilder(string value, int capacity) { }

	public StringBuilder(string value, int startIndex, int length, int capacity) { }

	public StringBuilder(int capacity, int maxCapacity) { }

	private StringBuilder(SerializationInfo info, StreamingContext context) { }

	private StringBuilder(StringBuilder from) { }

	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock) { }

	public StringBuilder Append(StringBuilder value) { }

	public StringBuilder Append(bool value) { }

	public StringBuilder Append(char value) { }

	public StringBuilder Append(byte value) { }

	public StringBuilder Append(Char[] value) { }

	[CLSCompliant(False)]
	public StringBuilder Append(uint value) { }

	public StringBuilder Append(object value) { }

	public StringBuilder Append(string value, int startIndex, int count) { }

	public StringBuilder Append(ReadOnlySpan<Char> value) { }

	[CLSCompliant(False)]
	public StringBuilder Append(Char* value, int valueCount) { }

	public StringBuilder Append(double value) { }

	public StringBuilder Append(string value) { }

	public StringBuilder Append(int value) { }

	public StringBuilder Append(char value, int repeatCount) { }

	public StringBuilder Append(Char[] value, int startIndex, int charCount) { }

	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	public StringBuilder AppendFormat(string format, Object[] args) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	public StringBuilder AppendFormat(string format, object arg0) { }

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	private void AppendHelper(string value) { }

	public StringBuilder AppendLine() { }

	public StringBuilder AppendLine(string value) { }

	private StringBuilder AppendSpanFormattable(T value) { }

	public StringBuilder Clear() { }

	public void CopyTo(int sourceIndex, Span<Char> destination, int count) { }

	public int EnsureCapacity(int capacity) { }

	private void ExpandByABlock(int minBlockCharCount) { }

	private StringBuilder FindChunkForIndex(int index) { }

	private static void FormatError() { }

	public int get_Capacity() { }

	public char get_Chars(int index) { }

	public int get_Length() { }

	public int get_MaxCapacity() { }

	private Span<Char> get_RemainingCurrentChunk() { }

	public StringBuilder Insert(int index, char value) { }

	public StringBuilder Insert(int index, string value) { }

	private void Insert(int index, Char* value, int valueCount) { }

	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	private StringBuilder Next(StringBuilder chunk) { }

	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

	public StringBuilder Remove(int startIndex, int length) { }

	public StringBuilder Replace(string oldValue, string newValue) { }

	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	private void ReplaceAllInChunk(Int32[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, Char* value, int count) { }

	public void set_Capacity(int value) { }

	public void set_Chars(int index, char value) { }

	public void set_Length(int value) { }

	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static void ThreadSafeCopy(Char* sourcePtr, Char[] destination, int destinationIndex, int count) { }

	private static void ThreadSafeCopy(Char[] source, int sourceIndex, Span<Char> destination, int destinationIndex, int count) { }

	public virtual string ToString() { }

	public string ToString(int startIndex, int length) { }

}

