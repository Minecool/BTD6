namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class OffsetToTrackTarget : TargetTypeBehavior
{
	public OffsetToTrackTarget parent; //Field offset: 0x98
	public float trackOffset; //Field offset: 0xA0
	public string expTrackOffset; //Field offset: 0xA8
	public Attack attack; //Field offset: 0xB0
	public Attack expAttack; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 354
	}

	public OffsetToTrackTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

