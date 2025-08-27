namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetTrackOrDefault : TargetTypeBehavior
{
	public TargetTrackOrDefault parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public bool useTowerRange; //Field offset: 0xB0
	public string expUseTowerRange; //Field offset: 0xB8
	public bool forceTargetTrack; //Field offset: 0xC0
	public string expForceTargetTrack; //Field offset: 0xC8
	public bool useClosestTrack; //Field offset: 0xD0
	public string expUseClosestTrack; //Field offset: 0xD8
	public float maxTrackOffset; //Field offset: 0xE0
	public string expMaxTrackOffset; //Field offset: 0xE8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 245
	}

	public TargetTrackOrDefault() { }

	public virtual AttackBehaviorModel get_Def() { }

}

