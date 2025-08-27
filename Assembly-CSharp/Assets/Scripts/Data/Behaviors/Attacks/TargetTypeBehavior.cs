namespace Assets.Scripts.Data.Behaviors.Attacks;

public abstract class TargetTypeBehavior : AttackBehavior
{
	public bool isSelectable; //Field offset: 0x30
	public bool isOnSubTower; //Field offset: 0x31

	protected TargetTypeBehavior() { }

}

