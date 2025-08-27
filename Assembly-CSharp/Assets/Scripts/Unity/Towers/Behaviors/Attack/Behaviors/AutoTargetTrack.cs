namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class AutoTargetTrack : TargetTypeBehavior
{
	public AutoTargetTrack parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public float maxOffset; //Field offset: 0xB0
	public string expMaxOffset; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public AutoTargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

