namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetTag : TargetTypeBehavior
{
	public TargetTag parent; //Field offset: 0x98
	[FormerlySerializedAs("tag")]
	public string tagValue; //Field offset: 0xA0
	[FormerlySerializedAs("expTag")]
	public string expTagValue; //Field offset: 0xA8
	public bool findStrongest; //Field offset: 0xB0
	public string expFindStrongest; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public TargetTag() { }

	public virtual AttackBehaviorModel get_Def() { }

}

