namespace Assets.Scripts.Unity.Towers.Behaviors;

public class NecromancerZone : TowerBehavior
{
	public NecromancerZone parent; //Field offset: 0x98
	public Attack attackUsedForRange; //Field offset: 0xA0
	public Attack expAttackUsedForRange; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 217
	}

	public NecromancerZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

