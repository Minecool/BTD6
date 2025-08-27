namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeySubParagonSupport : SupportBehavior
{
	public float subBonusDamageMultiplier; //Field offset: 0xC8
	public string expSubBonusDamageMultiplier; //Field offset: 0xD0
	public float subBonusPierceMultiplier; //Field offset: 0xD8
	public string expSubBonusPierceMultiplier; //Field offset: 0xE0
	public float heroBonusDamageMultiplier; //Field offset: 0xE8
	public string expHeroBonusDamageMultiplier; //Field offset: 0xF0
	public float heroBonusPierceMultiplier; //Field offset: 0xF8
	public string expHeroBonusPierceMultiplier; //Field offset: 0x100
	public float heroRateMultiplier; //Field offset: 0x108
	public string expHeroRateMultiplier; //Field offset: 0x110
	public float heroXpMultiplier; //Field offset: 0x118
	public string expHeroXpMultiplier; //Field offset: 0x120

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 322
	}

	public MonkeySubParagonSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

