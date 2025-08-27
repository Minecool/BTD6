namespace Assets.Scripts.Data.Legends;

public class MaxLivesXpShopMod : RogueXpShopMod
{
	public int maxLives; //Field offset: 0x10

	public MaxLivesXpShopMod() { }

	public virtual void ApplyIngameEffect(int level, GameModel moddedGameModel) { }

}

