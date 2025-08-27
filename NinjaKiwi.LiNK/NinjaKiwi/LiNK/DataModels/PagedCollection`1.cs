namespace NinjaKiwi.LiNK.DataModels;

public class PagedCollection
{
	public readonly int totalItems; //Field offset: 0x0
	public readonly int nextOffset; //Field offset: 0x0
	public readonly int pageLimit; //Field offset: 0x0
	private readonly List<T> itemList; //Field offset: 0x0

	public ICollection<T> Items
	{
		 get { } //Length: 5
	}

	public PagedCollection`1(int totalItems, int nextOffset, int pageLimit) { }

	public PagedCollection`1(int totalItems, int nextOffset, int pageLimit, IEnumerable<T> items) { }

	public ICollection<T> get_Items() { }

}

