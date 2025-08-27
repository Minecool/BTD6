namespace Firebase;

[DefaultMember("Item")]
internal class StringStringMap : IDisposable, IDictionary<String, String>, ICollection<KeyValuePair`2<String, String>>, IEnumerable<KeyValuePair`2<String, String>>, IEnumerable
{
	internal sealed class StringStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair`2<String, String>>, IDisposable
	{
		private StringStringMap collectionRef; //Field offset: 0x10
		private IList<String> keyCollection; //Field offset: 0x18
		private int currentIndex; //Field offset: 0x20
		private object currentObject; //Field offset: 0x28
		private int currentSize; //Field offset: 0x30

		public override KeyValuePair<String, String> Current
		{
			 get { } //Length: 357
		}

		private override object global::System.Collections.IEnumerator.Current
		{
			private get { } //Length: 84
		}

		public StringStringMapEnumerator(StringStringMap collection) { }

		public override void Dispose() { }

		public override KeyValuePair<String, String> get_Current() { }

		private override object global::System.Collections.IEnumerator.get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private HandleRef swigCPtr; //Field offset: 0x10
	protected bool swigCMemOwn; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 291
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 5
	}

	public override string Item
	{
		 get { } //Length: 358
		 set { } //Length: 358
	}

	public override ICollection<String> Keys
	{
		 get { } //Length: 1161
	}

	public override ICollection<String> Values
	{
		 get { } //Length: 756
	}

	internal StringStringMap(IntPtr cPtr, bool cMemoryOwn) { }

	public StringStringMap() { }

	public override void Add(string key, string value) { }

	public override void Add(KeyValuePair<String, String> item) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<String, String> item) { }

	public override bool ContainsKey(string key) { }

	public override void CopyTo(KeyValuePair<String, String>[] array, int arrayIndex) { }

	private IntPtr create_iterator_begin() { }

	private void destroy_iterator(IntPtr swigiterator) { }

	public override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override string get_Item(string key) { }

	public override ICollection<String> get_Keys() { }

	private string get_next_key(IntPtr swigiterator) { }

	public override ICollection<String> get_Values() { }

	internal static HandleRef getCPtr(StringStringMap obj) { }

	public StringStringMapEnumerator GetEnumerator() { }

	private string getitem(string key) { }

	private override IEnumerator<KeyValuePair`2<String, String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	private override IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	public override bool Remove(KeyValuePair<String, String> item) { }

	public override bool Remove(string key) { }

	public override void set_Item(string key, string value) { }

	private void setitem(string key, string x) { }

	private uint size() { }

	public override bool TryGetValue(string key, out string value) { }

}

