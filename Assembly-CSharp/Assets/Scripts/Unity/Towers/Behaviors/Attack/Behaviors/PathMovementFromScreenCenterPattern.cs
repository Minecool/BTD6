namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class PathMovementFromScreenCenterPattern : TargetTypeBehavior
{
	public PathMovementFromScreenCenterPattern parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public PathMovementFromScreenCenterPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

