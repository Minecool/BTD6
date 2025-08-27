namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "FinalStrike", menuName = "BTD6/Behaviors/Abilities/FinalStrike")]
public class FinalStrike : AbilityBehavior
{
	public float countdown; //Field offset: 0x30
	public float launchRate; //Field offset: 0x34
	public PrefabReference textEffectDisplay; //Field offset: 0x38
	public Projectile projectile; //Field offset: 0x40
	public Emission emission; //Field offset: 0x48
	public Effect effectDuringCountdown; //Field offset: 0x50
	public Effect launchEffect; //Field offset: 0x58
	public Effect launchEjectEffect; //Field offset: 0x60
	public int countdownAnimationStateSubmerged; //Field offset: 0x68
	public int countdownAnimationStateUnsubmerged; //Field offset: 0x6C
	public int launchAnimationStateSubmerged; //Field offset: 0x70
	public int launchAnimationStateUnsubmerged; //Field offset: 0x74
	public OffsetPosition launchEjectEffectThrowMarker; //Field offset: 0x78
	public Sound nukeCountDownSound; //Field offset: 0x80
	public Sound nukeLaunchSound; //Field offset: 0x88
	public int missileLaunchTime; //Field offset: 0x90

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 855
	}

	public FinalStrike() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

