namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BonusLivesPerRound : TowerBehavior
{
	public BonusLivesPerRound parent; //Field offset: 0x98
	public int amount; //Field offset: 0xA0
	public string expAmount; //Field offset: 0xA8
	public float lifespan; //Field offset: 0xB0
	public string expLifespan; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1137
	}

	public BonusLivesPerRound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

