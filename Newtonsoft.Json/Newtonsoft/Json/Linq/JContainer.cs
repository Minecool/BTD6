namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList
{
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; //Field offset: 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; //Field offset: 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; //Field offset: 0x40
	[Nullable(2)]
	private object _syncRoot; //Field offset: 0x48
	private bool _busy; //Field offset: 0x50

	protected abstract IList<JToken> ChildrenTokens
	{
		 get { } //Length: 0
	}

	public override int Count
	{
		 get { } //Length: 91
	}

	[Nullable(2)]
	public virtual JToken First
	{
		[NullableContext(2)]
		 get { } //Length: 138
	}

	public virtual bool HasValues
	{
		 get { } //Length: 97
	}

	[Nullable(2)]
	public virtual JToken Last
	{
		[NullableContext(2)]
		 get { } //Length: 139
	}

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
	{
		private get { } //Length: 20
		private set { } //Length: 17
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 107
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	[Nullable(2)]
	private override object System.Collections.IList.Item
	{
		[NullableContext(2)]
		private get { } //Length: 20
		[NullableContext(2)]
		private set { } //Length: 64
	}

	internal JContainer() { }

	internal JContainer(JContainer other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	public override void Add(object content) { }

	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	public void AddFirst(object content) { }

	internal void CheckReentrancy() { }

	public virtual JEnumerable<JToken> Children() { }

	internal override void ClearItems() { }

	[NullableContext(2)]
	internal override bool ContainsItem(JToken item) { }

	internal bool ContentsEqual(JContainer container) { }

	internal int ContentsHashCode() { }

	internal override void CopyItemsTo(Array array, int arrayIndex) { }

	internal static JToken CreateFromContent(object content) { }

	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	private JToken EnsureValue(object value) { }

	protected abstract IList<JToken> get_ChildrenTokens() { }

	public override int get_Count() { }

	[NullableContext(2)]
	public virtual JToken get_First() { }

	public virtual bool get_HasValues() { }

	[NullableContext(2)]
	public virtual JToken get_Last() { }

	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	internal abstract int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	internal bool IsMultiContent(object content) { }

	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	protected override void OnListChanged(ListChangedEventArgs e) { }

	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	public void RemoveAll() { }

	[NullableContext(2)]
	internal override bool RemoveItem(JToken item) { }

	internal override void RemoveItemAt(int index) { }

	internal override void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	internal override void SetItem(int index, JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	[NullableContext(2)]
	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	[NullableContext(2)]
	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	[NullableContext(2)]
	private override object System.Collections.IList.get_Item(int index) { }

	[NullableContext(2)]
	private override int System.Collections.IList.IndexOf(object value) { }

	[NullableContext(2)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[NullableContext(2)]
	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	[NullableContext(2)]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[NullableContext(2)]
	internal bool TryAdd(object content) { }

	[NullableContext(2)]
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	internal override void ValidateToken(JToken o, JToken existing) { }

}

