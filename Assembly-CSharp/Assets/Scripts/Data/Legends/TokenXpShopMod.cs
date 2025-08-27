namespace Assets.Scripts.Data.Legends;

public class TokenXpShopMod : RogueXpShopMod
{
	public int tokenAmount; //Field offset: 0x10

	public TokenXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

