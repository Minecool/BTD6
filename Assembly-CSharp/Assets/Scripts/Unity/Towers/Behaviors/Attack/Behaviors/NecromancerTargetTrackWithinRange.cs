namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class NecromancerTargetTrackWithinRange : TargetTypeBehavior
{
	public NecromancerTargetTrackWithinRange parent; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public GameObject displayInvalid; //Field offset: 0xB0
	public GameObject expDisplayInvalid; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 232
	}

	public NecromancerTargetTrackWithinRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

