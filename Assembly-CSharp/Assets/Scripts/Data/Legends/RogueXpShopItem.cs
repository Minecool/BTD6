namespace Assets.Scripts.Data.Legends;

[CreateAssetMenu(fileName = "RogueXpShopItem", menuName = "BTD6/RogueXpShopItem")]
public class RogueXpShopItem : ScriptableObject
{
	public string id; //Field offset: 0x18
	public int cost; //Field offset: 0x20
	public int maxLevel; //Field offset: 0x24
	public SpriteReference icon; //Field offset: 0x28
	[SerializeReference]
	private RogueXpShopMod[] xpShopMods; //Field offset: 0x30

	public RogueXpShopMod[] XpShopMods
	{
		 get { } //Length: 78
	}

	public RogueXpShopItem() { }

	public RogueXpShopMod[] get_XpShopMods() { }

	public int GetPurchaseCost(int level) { }

}

