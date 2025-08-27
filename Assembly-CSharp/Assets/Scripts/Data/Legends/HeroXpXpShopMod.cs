namespace Assets.Scripts.Data.Legends;

public class HeroXpXpShopMod : RogueXpShopMod
{
	public float heroXpMultiplierPerLevel; //Field offset: 0x10

	public HeroXpXpShopMod() { }

	public virtual void ApplyIngameEffect(int level, GameModel moddedGameModel) { }

	public virtual string GetBuffText(int level) { }

}

