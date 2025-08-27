namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PerRoundCashBonusTower : TowerBehavior
{
	public PerRoundCashBonusTower parent; //Field offset: 0x98
	public float cashPerRound; //Field offset: 0xA0
	public string expCashPerRound; //Field offset: 0xA8
	public float cashRoundBonusMultiplier; //Field offset: 0xB0
	public string expCashRoundBonusMultiplier; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8
	public bool distributeCash; //Field offset: 0xE0
	public string expDistributeCash; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1141
	}

	public PerRoundCashBonusTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

