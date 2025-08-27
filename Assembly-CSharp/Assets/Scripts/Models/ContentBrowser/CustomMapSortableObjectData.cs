namespace Assets.Scripts.Models.ContentBrowser;

public class CustomMapSortableObjectData
{
	public int layer; //Field offset: 0x10
	public int orderInLayer; //Field offset: 0x14

	public override int CategoryLayerId
	{
		 get { } //Length: 4
	}

	public CustomMapSortableObjectData() { }

	public bool Compare(CustomMapSortableObjectData com) { }

	public override int get_CategoryLayerId() { }

}

