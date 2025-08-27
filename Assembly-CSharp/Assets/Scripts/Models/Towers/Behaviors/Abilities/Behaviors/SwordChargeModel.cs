namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(SwordCharge), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwordChargeModel : AbilityBehaviorModel
{
	[SerializeField]
	private float initialDelay; //Field offset: 0x30
	public int initialDelayFrames; //Field offset: 0x34
	[SerializeField]
	private float endDelay; //Field offset: 0x38
	public int endDelayFrames; //Field offset: 0x3C
	public int iterations; //Field offset: 0x40
	public ProjectileModel projectileModel; //Field offset: 0x48
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x50
	public EffectModel effectAtEndModel; //Field offset: 0x58
	public EffectModel effectDuringCharge; //Field offset: 0x60
	[SerializeField]
	private float chargeEffectDestroyDelay; //Field offset: 0x68
	public int chargeEffectDestroyDelayFrames; //Field offset: 0x6C
	public SoundModel spawnSound; //Field offset: 0x70
	public SoundModel landingSound; //Field offset: 0x78

	public SwordChargeModel(string name, float initialDelay, float endDelay, int iterations, ProjectileModel projectileModel, EffectModel effectAtEndModel, EffectModel effectDuringCharge, float chargeEffectDestroyDelay, SoundModel spawnSound, SoundModel landingSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

