namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public abstract class TargetTypeBehavior : AttackBehavior
{
	public bool isSelectable; //Field offset: 0x88
	public string expIsSelectable; //Field offset: 0x90

	public bool IsOnSubTower
	{
		 get { } //Length: 126
	}

	protected TargetTypeBehavior() { }

	public bool get_IsOnSubTower() { }

}

