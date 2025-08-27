namespace Assets.Scripts.Data.Legends;

public class StartingCashXpShopMod : RogueXpShopMod
{
	public float startingCashPerLevelMultiplier; //Field offset: 0x10

	public StartingCashXpShopMod() { }

	public virtual void ApplyIngameEffect(int level, GameModel moddedGameModel) { }

	public virtual string GetBuffText(int level) { }

}

