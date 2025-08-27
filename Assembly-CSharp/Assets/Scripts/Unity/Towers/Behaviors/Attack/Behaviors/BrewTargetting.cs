namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class BrewTargetting : TargetTypeBehavior
{
	public BrewTargetting parent; //Field offset: 0x98
	public string towerIgnoreList; //Field offset: 0xA0
	public string expTowerIgnoreList; //Field offset: 0xA8
	public string ignoreMutationsByOrder; //Field offset: 0xB0
	public string expIgnoreMutationsByOrder; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 243
	}

	public BrewTargetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

