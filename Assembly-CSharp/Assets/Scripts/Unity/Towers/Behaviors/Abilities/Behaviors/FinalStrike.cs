namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class FinalStrike : AbilityBehavior
{
	public FinalStrike parent; //Field offset: 0x88
	public float countdown; //Field offset: 0x90
	public string expCountdown; //Field offset: 0x98
	public float launchRate; //Field offset: 0xA0
	public string expLaunchRate; //Field offset: 0xA8
	public GameObject textEffectDisplay; //Field offset: 0xB0
	public GameObject expTextEffectDisplay; //Field offset: 0xB8
	public Projectile projectile; //Field offset: 0xC0
	public Projectile expProjectile; //Field offset: 0xC8
	public Emission emission; //Field offset: 0xD0
	public Emission expEmission; //Field offset: 0xD8
	public Effect effectDuringCountdown; //Field offset: 0xE0
	public Effect expEffectDuringCountdown; //Field offset: 0xE8
	public Effect launchEffect; //Field offset: 0xF0
	public Effect expLaunchEffect; //Field offset: 0xF8
	public Effect launchEjectEffect; //Field offset: 0x100
	public Effect expLaunchEjectEffect; //Field offset: 0x108
	public int countdownAnimationStateSubmerged; //Field offset: 0x110
	public string expCountdownAnimationStateSubmerged; //Field offset: 0x118
	public int countdownAnimationStateUnsubmerged; //Field offset: 0x120
	public string expCountdownAnimationStateUnsubmerged; //Field offset: 0x128
	public int launchAnimationStateSubmerged; //Field offset: 0x130
	public string expLaunchAnimationStateSubmerged; //Field offset: 0x138
	public int launchAnimationStateUnsubmerged; //Field offset: 0x140
	public string expLaunchAnimationStateUnsubmerged; //Field offset: 0x148
	public GameObject launchEjectEffectThrowMarker; //Field offset: 0x150
	public AudioClip nukeCountDownSound; //Field offset: 0x158
	public AudioClip expNukeCountDownSound; //Field offset: 0x160
	public AudioClip nukeLaunchSound; //Field offset: 0x168
	public AudioClip expNukeLaunchSound; //Field offset: 0x170
	public int missileLaunchTime; //Field offset: 0x178
	public string expMissileLaunchTime; //Field offset: 0x180

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1315
	}

	public FinalStrike() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

