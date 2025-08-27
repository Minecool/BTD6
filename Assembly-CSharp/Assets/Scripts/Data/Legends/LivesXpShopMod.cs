namespace Assets.Scripts.Data.Legends;

public class LivesXpShopMod : RogueXpShopMod
{
	public float startLivesPerLevelMultiplier; //Field offset: 0x10

	public LivesXpShopMod() { }

	public virtual void ApplyIngameEffect(int level, GameModel moddedGameModel) { }

	public virtual string GetBuffText(int level) { }

}

