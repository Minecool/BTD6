namespace Assets.Scripts.Unity.Towers.Behaviors;

public class HeroXpPerRound : TowerBehavior
{
	public HeroXpPerRound parent; //Field offset: 0x98
	public float additionalXpPerRound; //Field offset: 0xA0
	public string expAdditionalXpPerRound; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public HeroXpPerRound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

