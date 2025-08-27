namespace NinjaKiwi.LiNK.DataModels;

public class MyNK_ItemModel
{
	public int id; //Field offset: 0x10
	public int cost; //Field offset: 0x14
	public string name; //Field offset: 0x18
	public string description; //Field offset: 0x20
	public string thumnailUrl; //Field offset: 0x28
	public bool hidden; //Field offset: 0x30
	public bool isACombo; //Field offset: 0x31
	public int maxBuyable; //Field offset: 0x34
	public int maxOwnable; //Field offset: 0x38
	public string uuid; //Field offset: 0x40
	public string tag; //Field offset: 0x48

	public MyNK_ItemModel() { }

}

