namespace Assets.Scripts.Data.Legends;

public class MapHeartsXpShopMod : RogueXpShopMod
{
	public int hearts; //Field offset: 0x10

	public MapHeartsXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

}

