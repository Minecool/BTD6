namespace Assets.Scripts.Data.Store;

public class LootThemeItem
{
	public LootThemeType themeType; //Field offset: 0x10
	public LootItemType itemType; //Field offset: 0x14
	public PrefabReference prefab; //Field offset: 0x18

	public LootThemeItem() { }

}

