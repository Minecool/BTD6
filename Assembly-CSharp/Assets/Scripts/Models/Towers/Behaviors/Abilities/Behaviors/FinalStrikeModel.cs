namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(FinalStrike), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FinalStrikeModel : AbilityBehaviorModel
{
	public float countdown; //Field offset: 0x30
	public int countdownFrames; //Field offset: 0x34
	public float launchRate; //Field offset: 0x38
	public int launchRateFrames; //Field offset: 0x3C
	public PrefabReference textEffectDisplay; //Field offset: 0x40
	public ProjectileModel projectileModel; //Field offset: 0x48
	public EmissionModel emissionModel; //Field offset: 0x50
	public float throwOffsetX; //Field offset: 0x58
	public float throwOffsetY; //Field offset: 0x5C
	public float throwOffsetZ; //Field offset: 0x60
	public EffectModel effectDuringCountdownModel; //Field offset: 0x68
	public EffectModel launchEffectModel; //Field offset: 0x70
	public EffectModel launchEjectEffectModel; //Field offset: 0x78
	public int countdownAnimationStateSubmerged; //Field offset: 0x80
	public int countdownAnimationStateUnsubmerged; //Field offset: 0x84
	public int launchAnimationStateSubmerged; //Field offset: 0x88
	public int launchAnimationStateUnsubmerged; //Field offset: 0x8C
	public SoundModel nukeCountDownSoundModel; //Field offset: 0x90
	public SoundModel nukeLaunchSoundModel; //Field offset: 0x98
	public int missileLaunchTime; //Field offset: 0xA0

	public FinalStrikeModel(string name, float countdown, float launchRate, PrefabReference textEffectDisplay, ProjectileModel projectileModel, EmissionModel emissionModel, float throwOffsetX, float throwOffsetY, float throwOffsetZ, EffectModel effectDuringCountdownModel, EffectModel launchEffectModel, EffectModel launchEjectEffectModel, int countdownAnimationStateSubmerged, int countdownAnimationStateUnsubmerged, int launchAnimationStateSubmerged, int launchAnimationStateUnsubmerged, SoundModel nukeCountDownSoundModel, SoundModel nukeLaunchSoundModel, int missileLaunchTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

