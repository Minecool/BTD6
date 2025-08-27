namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(LeapingSword), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LeapingSwordModel : AbilityBehaviorModel
{
	[SerializeField]
	private float timeUntilFinish; //Field offset: 0x30
	public int timeUntilFinishFrames; //Field offset: 0x34
	[SerializeField]
	private float landDelay; //Field offset: 0x38
	public int landDelayFrames; //Field offset: 0x3C
	public ProjectileModel impactProjectileModel; //Field offset: 0x40
	public ProjectileModel dotProjectileModel; //Field offset: 0x48
	public EffectModel effectAtTarget; //Field offset: 0x50
	public EffectModel impactEffectModel; //Field offset: 0x58
	public EffectModel finishingEffectModel; //Field offset: 0x60
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x68
	[SerializeField]
	private float finishingEffectDelay; //Field offset: 0x70
	public int finishingEffectDelayFrames; //Field offset: 0x74
	public SoundModel landingSound; //Field offset: 0x78

	public LeapingSwordModel(string name, float timeUntilFinish, float landDelay, ProjectileModel impactProjectileModel, ProjectileModel dotProjectileModel, EffectModel effectAtTarget, EffectModel impactEffectModel, EffectModel finishingEffectModel, float finishingEffectDelay, SoundModel landingSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

