namespace NinjaKiwi.GUTS.Models;

public class TrophyStoreBankItem
{
	public string description; //Field offset: 0x10
	public Cost cost; //Field offset: 0x18
	public Dictionary<String, Int32> reward; //Field offset: 0x20

	public TrophyStoreBankItem() { }

}

