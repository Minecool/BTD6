namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class FarTargetTrack : TargetTypeBehavior
{
	public FarTargetTrack parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public float donutRadius; //Field offset: 0xB0
	public string expDonutRadius; //Field offset: 0xB8
	public float maxOffset; //Field offset: 0xC0
	public string expMaxOffset; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 215
	}

	public FarTargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

