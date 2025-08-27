namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MonkeySubParagonSupport", menuName = "BTD6/Behaviors/Towers/MonkeySubParagonSupport")]
public class MonkeySubParagonSupport : SupportBehavior
{
	public float subBonusDamageMultiplier; //Field offset: 0x48
	public float subBonusPierceMultiplier; //Field offset: 0x4C
	public float heroBonusDamageMultiplier; //Field offset: 0x50
	public float heroBonusPierceMultiplier; //Field offset: 0x54
	public float heroRateMultiplier; //Field offset: 0x58
	public float heroXpMultiplier; //Field offset: 0x5C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 298
	}

	public MonkeySubParagonSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

