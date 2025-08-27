namespace Assets.Scripts.Data.GeraldoItems;

public class GeraldoItemsData : ScriptableObject
{
	[SerializeField]
	private List<GeraldoItem> items; //Field offset: 0x18

	public IEnumerable<GeraldoItem> Items
	{
		 get { } //Length: 5
	}

	public GeraldoItemsData() { }

	public IEnumerable<GeraldoItem> get_Items() { }

}

