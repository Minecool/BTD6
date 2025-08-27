namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class NameValueCollection : NameObjectCollectionBase
{
	private String[] _all; //Field offset: 0x50
	private String[] _allKeys; //Field offset: 0x58

	public string Item
	{
		 get { } //Length: 20
		 set { } //Length: 17
	}

	public NameValueCollection() { }

	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	internal NameValueCollection(DBNull dummy) { }

	public NameValueCollection(int capacity) { }

	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	public override void Add(string name, string value) { }

	public override string Get(int index) { }

	public override string Get(string name) { }

	public string get_Item(string name) { }

	private static string GetAsOneString(ArrayList list) { }

	private static String[] GetAsStringArray(ArrayList list) { }

	public override string GetKey(int index) { }

	public override String[] GetValues(string name) { }

	public override String[] GetValues(int index) { }

	protected void InvalidateCachedArrays() { }

	public override void Remove(string name) { }

	public override void Set(string name, string value) { }

	public void set_Item(string name, string value) { }

}

