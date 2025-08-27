namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetCloseSharedRange : TargetTypeBehavior
{
	public TargetCloseSharedRange parent; //Field offset: 0x98
	public bool isSharedRangeEnabled; //Field offset: 0xA0
	public string expIsSharedRangeEnabled; //Field offset: 0xA8
	public bool isGlobalRange; //Field offset: 0xB0
	public string expIsGlobalRange; //Field offset: 0xB8
	public bool getRangeFromSpecificTower; //Field offset: 0xC0
	public string expGetRangeFromSpecificTower; //Field offset: 0xC8
	public string specificTowerType; //Field offset: 0xD0
	public string expSpecificTowerType; //Field offset: 0xD8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 209
	}

	public TargetCloseSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

