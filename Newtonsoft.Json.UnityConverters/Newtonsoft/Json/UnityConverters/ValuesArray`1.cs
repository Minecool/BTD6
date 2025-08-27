namespace Newtonsoft.Json.UnityConverters;

[DefaultMember("Item")]
public struct ValuesArray : IReadOnlyList<TInner>, IEnumerable<TInner>, IEnumerable, IReadOnlyCollection<TInner>, IDisposable
{
	private NativeArray<TInner> _array; //Field offset: 0x0

	public override TInner Item
	{
		 get { } //Length: 262
		 set { } //Length: 248
	}

	public int Length
	{
		 get { } //Length: 112
	}

	private override int System.Collections.Generic.IReadOnlyCollection<TInner>.Count
	{
		private get { } //Length: 112
	}

	public ValuesArray`1(TInner[] array, Allocator allocator) { }

	public ValuesArray`1(int capacity, Allocator allocator, NativeArrayOptions options = 1) { }

	public override void Dispose() { }

	public override TInner get_Item(int index) { }

	public int get_Length() { }

	public T GetAsTypeOrDefault(int index) { }

	public T GetAsTypeOrDefault(int index, T fallback) { }

	public override IEnumerator<TInner> GetEnumerator() { }

	public void set_Item(int index, TInner value) { }

	private override int System.Collections.Generic.IReadOnlyCollection<TInner>.get_Count() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

