namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetTrack : TargetTypeBehavior
{
	public TargetTrack parent; //Field offset: 0x98
	public float maxOffset; //Field offset: 0xA0
	public string expMaxOffset; //Field offset: 0xA8
	public string expOnlyTargetPathsWithBloons; //Field offset: 0xB0
	public bool onlyTargetPathsWithBloons; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public TargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

