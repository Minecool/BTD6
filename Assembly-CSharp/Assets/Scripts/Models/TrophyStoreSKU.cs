namespace Assets.Scripts.Models;

public class TrophyStoreSKU : EnableFlag
{
	[Obsolete("Use IsHidden() instead!")]
	public String[] hiddenItems; //Field offset: 0x18
	public String[] newItems; //Field offset: 0x20

	public TrophyStoreSKU() { }

	public bool IsHidden(TrophyStoreItem trophyStoreItem) { }

	public bool IsHidden(string trophyStoreItemId) { }

}

