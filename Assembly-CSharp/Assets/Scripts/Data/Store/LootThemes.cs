namespace Assets.Scripts.Data.Store;

[CreateAssetMenu(menuName = "BTD6/Loot Themes")]
public class LootThemes : ScriptableObject
{
	[SerializeField]
	private List<LootThemeItem> lootThemes; //Field offset: 0x18

	public LootThemes() { }

	public PrefabReference GetTheme(LootThemeType themeType, LootItemType itemType) { }

}

