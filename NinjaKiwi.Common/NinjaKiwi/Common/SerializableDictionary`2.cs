namespace NinjaKiwi.Common;

[DefaultMember("Item")]
public class SerializableDictionary : IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{
	[SerializeField]
	private List<TKey> keys; //Field offset: 0x0
	[SerializeField]
	private List<TValue> values; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public TValue Item
	{
		 get { } //Length: 166
		 set { } //Length: 151
	}

	public ICollection<TKey> Keys
	{
		 get { } //Length: 5
	}

	public ICollection<TValue> Values
	{
		 get { } //Length: 5
	}

	public SerializableDictionary`2() { }

	public SerializableDictionary`2(Dictionary<TKey, TValue> other) { }

	public void Add(KeyValuePair<TKey, TValue> kvPair) { }

	public void Add(TKey key, TValue value) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	private int FindIndex(TKey key) { }

	public int get_Count() { }

	public TValue get_Item(TKey key) { }

	public ICollection<TKey> get_Keys() { }

	public ICollection<TValue> get_Values() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public bool Remove(TKey key) { }

	private void SanityCheck() { }

	public void set_Item(TKey key, TValue value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

