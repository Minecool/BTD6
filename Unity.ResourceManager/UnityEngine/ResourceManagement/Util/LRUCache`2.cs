namespace UnityEngine.ResourceManagement.Util;

internal struct LRUCache
{
	internal struct Entry : IEquatable<Entry<TKey, TValue>>
	{
		public LinkedListNode<TKey> lruNode; //Field offset: 0x0
		public TValue Value; //Field offset: 0x0

		public override bool Equals(Entry<TKey, TValue> other) { }

		public virtual int GetHashCode() { }

	}

	private int entryLimit; //Field offset: 0x0
	private Dictionary<TKey, Entry<TKey, TValue>> cache; //Field offset: 0x0
	private LinkedList<TKey> lru; //Field offset: 0x0

	public LRUCache`2(int limit) { }

	public bool TryAdd(TKey id, TValue obj) { }

	public bool TryGet(TKey offset, out TValue val) { }

}

